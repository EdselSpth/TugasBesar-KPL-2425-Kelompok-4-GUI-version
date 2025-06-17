using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule;
using View_Regreen.Menu;

namespace View_Regreen.Admin
{
    public partial class MenuValidasiArea : Form
    {
        // Daftar area yang akan divalidasi
        private List<ConfigPendaftaranArea> daftarArea = new();

        // Daftar nama pengguna untuk ditampilkan di tabel
        private List<string> namaPengguna = new()
        {
            "Aulia Rahma", "Budi Santoso", "Citra Lestari", "Dedi Firmansyah",
            "Eka Putri", "Faisal Akbar", "Gita Yuliana"
        };

        // Daftar status masing-masing area (menunggu, diterima, ditolak)
        private List<string> statusArea = new();

        // Konstruktor Form
        public MenuValidasiArea()
        {
            InitializeComponent();

            // Mengatur warna latar belakang form dan panel
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");

            // Menambahkan handler untuk mewarnai baris berdasarkan status
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
        }

        // Method yang dijalankan saat form pertama kali dimuat
        private void MenuValidasiArea_Load(object sender, EventArgs e)
        {
            ConfigPendaftaranArea config = new ConfigPendaftaranArea();
            daftarArea = config.GetAllArea();

            dataGridView1.Rows.Clear();
            statusArea.Clear();

            int no = 1;

            // Menambahkan data area ke tabel dengan status awal "menunggu"
            for (int i = 0; i < daftarArea.Count; i++)
            {
                string nama = i < namaPengguna.Count ? namaPengguna[i] : "Pengguna Default";
                string area = daftarArea[i].Area;
                string status = "menunggu";

                dataGridView1.Rows.Add(no++, nama, area, status);
                statusArea.Add(status);
            }

            // Menghilangkan seleksi default pada tabel
            dataGridView1.ClearSelection();
        }

        // Event handler untuk tombol "Diterima"
        private void Btn_diterima_Click(object sender, EventArgs e)
        {
            // Validasi status dengan nilai "diterima"
            ValidasiStatus("diterima");
        }

        // Event handler untuk tombol "Ditolak"
        private void Btn_ditolak_Click(object sender, EventArgs e)
        {
            // Validasi status dengan nilai "ditolak"
            ValidasiStatus("ditolak");
        }

        // Method untuk memvalidasi status area pada baris yang dipilih
        private void ValidasiStatus(string newStatus)
        {
            // Jika ada baris yang dipilih
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;

                // Ambil nilai status dari kolom status (Column4)
                object statusObj = dataGridView1.Rows[index].Cells["Column4"].Value;

                // Validasi jika nilai status kosong
                if (statusObj == null)
                {
                    MessageBox.Show("Status tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string currentStatus = statusObj.ToString();

                // Cek apakah status sudah divalidasi sebelumnya
                if (currentStatus != "menunggu")
                {
                    MessageBox.Show("Status sudah divalidasi dan tidak dapat diubah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ubah status di tampilan dan list statusArea
                dataGridView1.Rows[index].Cells["Column4"].Value = newStatus;
                statusArea[index] = newStatus;

                // Simpan perubahan status ke file JSON
                SimpanStatus();
            }
            else
            {
                // Jika belum ada baris yang dipilih
                MessageBox.Show("Silakan pilih satu baris terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Method untuk menyimpan status validasi area ke file JSON
        private void SimpanStatus()
        {
            var hasilValidasi = new List<object>();

            for (int i = 0; i < daftarArea.Count; i++)
            {
                string nama = i < namaPengguna.Count ? namaPengguna[i] : "Pengguna Default";

                hasilValidasi.Add(new
                {
                    area = daftarArea[i].Area,
                    nama_pengguna = nama,
                    status = statusArea[i]
                });
            }

            string simpanPath = Path.Combine(Application.StartupPath, "hasilValidasiArea.json");
            string json = JsonSerializer.Serialize(hasilValidasi, new JsonSerializerOptions { WriteIndented = true });

            // Tulis hasil validasi ke file JSON
            File.WriteAllText(simpanPath, json);
        }

        // Event handler untuk memberikan warna abu-abu pada baris yang statusnya sudah divalidasi
        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                var cell = row.Cells["Column4"];
                if (cell != null && cell.Value != null)
                {
                    string status = cell.Value.ToString();

                    // Jika status selain "menunggu", beri warna abu-abu
                    if (status != "menunggu")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                }
            }
        }

        // Method untuk navigasi ke Dashboard Admin
        private void Beranda_Click(object sender, EventArgs e)
        {
            var dashboard = new DashboardAdmin();
            dashboard.Show();
            this.Hide();
        }

        // Method untuk navigasi ke menu penjadwalan
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            var penjadwalan = new MenuPenjadwalan();
            penjadwalan.Show();
            this.Hide();
        }

        // Method untuk navigasi ke menu validasi keuntungan
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            var keuntungan = new MenuValidasiKeuntungan();
            keuntungan.Show();
            this.Hide();
        }

        // Method untuk keluar dan kembali ke login
        private void PictureBox6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Jika pengguna memilih Yes, lakukan logout
            if (result == DialogResult.Yes)
            {
                Session.Username = null;
                Session.Role = null;

                var menuLogin = new MenuLogin();
                menuLogin.Show();
                this.Close();
            }
        }
    }
}

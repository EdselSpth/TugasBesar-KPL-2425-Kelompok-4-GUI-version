// Import library dan dependensi yang dibutuhkan
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule;
using View_Regreen.Menu;

namespace View_Regreen.User
{
    public partial class MenuDaftarArea : Form
    {
        // Konstruktor form
        public MenuDaftarArea()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");
            Load += MenuDaftarArea_Load;
        }

        // Method yang dijalankan saat form pertama kali diload
        private void MenuDaftarArea_Load(object sender, EventArgs e)
        {
            LoadDataArea();
        }

        // Method untuk menangani klik tombol Daftarkan
        private void ButtonDaftarkan_Click(object sender, EventArgs e)
        {
            string namaArea = textBox1.Text.Trim();

            // Validasi input sebelum diproses
            if (!ValidasiInput(namaArea))
            {
                return;
            }

            //Try untuk mencoba menyimpan data
            try
            {
                var areaManager = new configPendaftaraanArea();
                var semuaArea = areaManager.GetAllArea() ?? new List<configPendaftaraanArea>();

                // Cek apakah area sudah terdaftar sebelumnya
                if (semuaArea.Any(area => area.area?.Equals(namaArea, StringComparison.OrdinalIgnoreCase) == true))
                {
                    MessageBox.Show("Area sudah terdaftar. Silakan masukkan nama yang berbeda.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var areaBaru = new configPendaftaraanArea { area = namaArea };
                areaBaru.saveArea();

                MessageBox.Show("Area berhasil didaftarkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear(); 
                LoadDataArea(); 
            }
            catch (Exception ex)
            {
                // Tangani error saat penyimpanan
                MessageBox.Show("Terjadi kesalahan saat menyimpan area.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method validasi input user
        private bool ValidasiInput(string input)
        {
            // Cek apakah input kosong
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Nama area tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Cek apakah input hanya huruf dan spasi
            if (!Regex.IsMatch(input, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Nama area hanya boleh berisi huruf dan spasi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Input valid
        }

        // Method untuk menampilkan semua data area ke DataGridView
        private void LoadDataArea()
        {
            try
            {
                var areaManager = new configPendaftaraanArea();
                var semuaArea = areaManager.GetAllArea();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Tampilkan pesan jika tidak ada data
                if (semuaArea == null || semuaArea.Count == 0)
                {
                    MessageBox.Show("Belum ada area yang terdaftar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridView1.Columns.Add("id", "ID");
                dataGridView1.Columns.Add("area", "Area");

                //pengambilan untuk setiap area
                foreach (var area in semuaArea)
                {
                    // Tambahkan hanya jika area tidak kosong
                    if (!string.IsNullOrWhiteSpace(area.area))
                    {
                        dataGridView1.Rows.Add(area.id, area.area);
                    }
                }
            }
            catch (Exception ex)
            {
                // Tangani error saat load data
                MessageBox.Show("Gagal menampilkan data area.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method navigasi ke form tujuan
        private void Navigasi(Form targetForm)
        {
            // Cek apakah form tujuan valid
            if (targetForm == null)
            {
                return;
            }

            //Coba buka form
            try
            {
                targetForm.Show();
                Hide(); // Sembunyikan form saat ini
            }
            //pengangan jika terjadi error
            catch (Exception ex)
            {
                
                MessageBox.Show("Gagal membuka form tujuan.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method logout user dari sistem
        private void Logout()
        {
            // Tampilkan konfirmasi sebelum logout
            if (MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Session.Username = null;
                Session.Role = null;

                try
                {
                    new MenuLogin().Show();
                    Close(); // Tutup form saat ini
                }
                catch (Exception ex)
                {
                    // Tangani error jika gagal logout
                    MessageBox.Show("Gagal logout.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event klik untuk navigasi ke halaman Daftar Pengambilan
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Navigasi(new MenuDaftarPengambilan());
        }

        // Event klik untuk navigasi ke halaman Penarikan Keuntungan
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Navigasi(new MenuPenarikanKeuntungan());
        }
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Navigasi(new MenuDaftarArea());
        }

        // Event klik untuk navigasi ke halaman Dashboard
        private void Beranda_Click(object sender, EventArgs e)
        {
            Navigasi(new DashboardUser());
        }

        // Event klik logout melalui PictureBox
        private void PictureBox6_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}

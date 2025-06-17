using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_Regreen.Menu;

namespace View_Regreen.Admin
{
    public partial class MenuValidasiKeuntungan : Form
    {
        // Komponen DataGridView untuk menampilkan data pengajuan keuntungan
        private DataGridView dgvPengajuan;

        public MenuValidasiKeuntungan()
        {
            InitializeComponent(); // Inisialisasi komponen dari Designer
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");

            // Atur ukuran dan posisi form
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Validasi Keuntungan";

            // Konfigurasi dan tampilkan tabel serta isi data dummy
            SetupDataGridView();
            LoadDataDummy();
        }

        // Menyiapkan DataGridView beserta konfigurasi tampilannya
        private void SetupDataGridView()
        {
            dgvPengajuan = new DataGridView
            {
                Size = new System.Drawing.Size(900, 300),
                Location = new System.Drawing.Point(50, 50),
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // Menentukan jumlah dan nama kolom
            dgvPengajuan.ColumnCount = 6;
            dgvPengajuan.Columns[0].Name = "No";
            dgvPengajuan.Columns[1].Name = "Nama";
            dgvPengajuan.Columns[2].Name = "Nominal";
            dgvPengajuan.Columns[3].Name = "Nomor";
            dgvPengajuan.Columns[4].Name = "Metode";
            dgvPengajuan.Columns[5].Name = "Status";

            // Tambahkan DataGridView ke panel tampilan
            PanelDummy.Controls.Add(dgvPengajuan);
        }

        // Memuat data dummy ke dalam DataGridView
        private void LoadDataDummy()
        {
            var data = new List<string[]>
            {
                new[] { "1", "Budi Santoso", "Rp150.000", "1239738290", "BCA", "Pending" },
                new[] { "2", "Ahmad Solihin", "Rp50.000", "1203239200", "Mandiri", "Pending" },
                new[] { "3", "Bagas Kopling", "Rp100.000", "21091288329", "Mandiri", "Pending" }
            };

            foreach (var row in data)
            {
                dgvPengajuan.Rows.Add(row);
            }
        }

        // Event handler untuk tombol "Terima" - mengubah status menjadi "Diterima"
        private void button1_ClickTerima(object sender, EventArgs e)
        {
            if (dgvPengajuan.SelectedRows.Count > 0) // Memastikan ada baris yang dipilih
            {
                string nama = dgvPengajuan.SelectedRows[0].Cells[1].Value.ToString(); // Mengambil nama dari baris yang dipilih admin
                dgvPengajuan.SelectedRows[0].Cells[5].Value = "Diterima"; // Mengubah status menjadi "Diterima"

                MessageBox.Show($"Permintaan 1 oleh {nama} disetujui", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Jika tidak ada baris yang dipilih
            {
                MessageBox.Show("Silakan pilih satu baris terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler untuk tombol "Tolak" - mengubah status menjadi "Ditolak"
        private void button2_ClickTolak(object sender, EventArgs e)
        {
            if (dgvPengajuan.SelectedRows.Count > 0) // Memastikan ada baris yang dipilih
            {
                string nama = dgvPengajuan.SelectedRows[0].Cells[1].Value.ToString(); // Mengambil nama dari baris yang dipilih admin
                dgvPengajuan.SelectedRows[0].Cells[5].Value = "Ditolak"; // Mengubah status menjadi "Ditolak"
                MessageBox.Show("Permintaan ditolak.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Jika tidak ada baris yang dipilih
            {
                MessageBox.Show("Silakan pilih satu baris terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler untuk menggambar ulang panel validasi (kosong, bisa digunakan untuk dekorasi UI)
        private void panel1_PaintValidasi(object sender, PaintEventArgs e)
        {
            // Optional logic
        }

        // Event handler untuk menggambar ulang panel daftar data (kosong, bisa digunakan untuk dekorasi UI)
        private void panel2_PaintListData(object sender, PaintEventArgs e)
        {
            // Optional logic
        }

        // Navigasi ke beranda (Dashboard Admin)
        private void Beranda_Click(object sender, EventArgs e)
        {
            var dashboard = new DashboardAdmin();
            dashboard.Show();
            this.Hide();
        }

        // Navigasi ke menu penjadwalan
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var penjadwalan = new MenuPenjadwalan();
            penjadwalan.Show();
            this.Hide();
        }

        // Navigasi ke menu validasi area
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var area = new MenuValidasiArea();
            area.Show();
            this.Hide();
        }

        // Event handler untuk logout dan kembali ke form login
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Hapus session login
                Session.Username = null;
                Session.Role = null;

                // Tampilkan form login
                var menuLogin = new MenuLogin();
                menuLogin.Show();

                // Tutup form saat ini
                this.Close();
            }
        }

        // Event saat form dimuat (belum ada logic)
        private void MenuValidasiKeuntungan_Load(object sender, EventArgs e)
        {
            // Optional logic saat form pertama kali ditampilkan

        }

        private void MenuValidasiKeuntungan_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
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

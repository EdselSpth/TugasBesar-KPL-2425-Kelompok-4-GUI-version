using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule;
using View_Regreen.Menu;

namespace View_Regreen.User
{
    public partial class MenuDaftarArea : Form
    {
        public MenuDaftarArea()
        {
            InitializeComponent();
            this.Load += new EventHandler(MenuDaftarArea_Load);
        }

        private void button_Daftarkan_Click(object sender, EventArgs e)
        {
            try
            {
                string inputArea = textBox1.Text.Trim();

                // Validasi input kosong
                if (string.IsNullOrWhiteSpace(inputArea))
                {
                    MessageBox.Show("Nama area tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi karakter input (hanya huruf dan spasi)
                if (!System.Text.RegularExpressions.Regex.IsMatch(inputArea, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Nama area hanya boleh berisi huruf dan spasi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cek duplikat area
                var areaManager = new configPendaftaraanArea();
                bool areaSudahAda = areaManager.GetAllArea()
                    .Any(area => !string.IsNullOrWhiteSpace(area.area) &&
                                 area.area.Equals(inputArea, StringComparison.OrdinalIgnoreCase));

                if (areaSudahAda)
                {
                    MessageBox.Show("Area sudah terdaftar. Silakan masukkan nama yang berbeda.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Simpan area baru
                var areaBaru = new configPendaftaraanArea
                {
                    area = inputArea
                };

                areaBaru.saveArea();

                MessageBox.Show("Area berhasil didaftarkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                TampilkanAreaKeTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mendaftarkan area.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TampilkanAreaKeTabel()
        {
            try
            {
                var areaManager = new configPendaftaraanArea();
                var semuaArea = areaManager.GetAllArea();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                if (semuaArea == null || semuaArea.Count == 0)
                {
                    MessageBox.Show("Belum ada area yang terdaftar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Tambahkan kolom jika belum ada
                dataGridView1.Columns.Add("id", "ID");
                dataGridView1.Columns.Add("area", "Area");

                // Tambahkan data ke dalam tabel
                foreach (var area in semuaArea)
                {
                    if (area != null && !string.IsNullOrWhiteSpace(area.area))
                    {
                        dataGridView1.Rows.Add(area.id, area.area);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data area.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MenuDaftarArea_Load(object sender, EventArgs e)
        {
            try
            {
                TampilkanAreaKeTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data area.\n" + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var menuDaftarPengambilan = new MenuDaftarPengambilan();
            menuDaftarPengambilan.Show();
            this.Hide(); // Sembunyikan form saat ini
        }

        private void Beranda_Click(object sender, EventArgs e)
        {
            var dashboardUser = new DashboardUser();
            dashboardUser.Show();
            this.Hide(); // Sembunyikan form saat ini
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var menuPenarikanKeuntungan = new MenuPenarikanKeuntungan();
            menuPenarikanKeuntungan.Show();
            this.Hide();// Sembunyikan form saat ini
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Session.Username = null; // Hapus username dari session
                Session.Role = null; // Hapus role dari session

                // Kembali ke menu login
                var menuLogin = new MenuLogin();
                menuLogin.Show();

                this.Close(); // Sembunyikan form saat ini
            }
        }
    }
}

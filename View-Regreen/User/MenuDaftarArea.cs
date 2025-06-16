using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
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
            Load += MenuDaftarArea_Load;
        }

        private void MenuDaftarArea_Load(object sender, EventArgs e)
        {
            LoadDataArea();
        }

        private void button_Daftarkan_Click(object sender, EventArgs e)
        {
            string namaArea = textBox1.Text.Trim();

            // Validasi input sebelum diproses
            if (!ValidasiInput(namaArea)) return;

            var areaManager = new configPendaftaraanArea();
            var semuaArea = areaManager.GetAllArea();

            bool sudahAda = semuaArea.Any(area => area.area?.Equals(namaArea, StringComparison.OrdinalIgnoreCase) == true);

            //pengecekan duplikasi area
            if (sudahAda)
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

        private bool ValidasiInput(string input)
        {
            // Cek apakah input kosong
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Nama area tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Cek apakah input mengandung karakter selain huruf dan spasi
            if (!Regex.IsMatch(input, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Nama area hanya boleh berisi huruf dan spasi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LoadDataArea()
        {
            try
            {
                var areaManager = new configPendaftaraanArea();
                var semuaArea = areaManager.GetAllArea();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Jika tidak ada area yang tersimpan
                if (semuaArea == null || semuaArea.Count == 0)
                {
                    MessageBox.Show("Belum ada area yang terdaftar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridView1.Columns.Add("id", "ID");
                dataGridView1.Columns.Add("area", "Area");

                // Tambahkan baris berdasarkan data area
                foreach (var area in semuaArea)
                {
                    // Tambahkan hanya jika area tidak kosong/null
                    if (!string.IsNullOrWhiteSpace(area.area))
                        dataGridView1.Rows.Add(area.id, area.area);
                }
            }
            catch (Exception ex)
            {
                // Tangani error jika gagal membaca atau menampilkan data
                MessageBox.Show("Gagal menampilkan data area.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) => Navigasi(new MenuDaftarPengambilan());
        private void pictureBox3_Click(object sender, EventArgs e) => Navigasi(new MenuPenarikanKeuntungan());
        private void pictureBox3_Click_1(object sender, EventArgs e) => Navigasi(new MenuPenarikanKeuntungan());
        private void Beranda_Click(object sender, EventArgs e) => Navigasi(new DashboardUser());
        private void Beranda_Click_1(object sender, EventArgs e) => Navigasi(new DashboardUser());

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Tampilkan konfirmasi logout
            if (MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Session.Username = null;
                Session.Role = null;

                new MenuLogin().Show();
                Close();
            }
        }

        private void Navigasi(Form targetForm)
        {
            targetForm.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Jika user memilih Yes, lakukan logout
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelLibrary;
using JadwalAPI;
using View_Regreen.Menu;
using JadwalAPI.Model;

namespace View_Regreen.Admin
{
    public partial class MenuPenjadwalan : Form
    {
        // Inisialisasi HttpClient untuk melakukan request ke API
        private readonly HttpClient _httpClient = new();

        // Menyimpan daftar semua jadwal yang dimuat dari API
        private List<JadwalAPI.Model.JadwalModel> _allJadwals = new();

        public MenuPenjadwalan()
        {
            InitializeComponent();

            // Mengatur warna latar belakang form dan panel sesuai tema aplikasi
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");
        }

        // Method untuk mengambil semua data jadwal dari API dan menampilkannya di DataGridView
        private async Task LoadAllJadwalAsync()
        {
            try
            {
                string url = "https://localhost:7277/api/jadwal_admin";
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Lempar exception jika status bukan sukses (2xx)

                var jsonString = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true // Agar deserialisasi tidak sensitif huruf besar/kecil
                };

                // Deserialize response JSON menjadi list model jadwal
                var jadwals = JsonSerializer.Deserialize<List<JadwalAPI.Model.JadwalModel>>(jsonString, options);

                // Jika data berhasil diambil, tampilkan ke DataGridView
                if (jadwals != null)
                {
                    _allJadwals = jadwals;
                    dataGridView1.DataSource = _allJadwals;
                }
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error jika terjadi exception
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        // Event handler saat form dimuat, langsung memuat data jadwal
        private async void MenuPenjadwalan_Load(object sender, EventArgs e)
        {
            await LoadAllJadwalAsync();
        }

        // Tombol untuk berpindah ke form hapus jadwal
        private void button_hapusJadwal_Click(object sender, EventArgs e)
        {
            var hapusJadwalForm = new HapusJadwal();
            hapusJadwalForm.ShowDialog();
            this.Hide();
        }

        // Tombol untuk berpindah ke form tambah jadwal
        private void button_TambahJadwal_Click(object sender, EventArgs e)
        {
            var tambahJadwalForm = new TambahJadwal();
            tambahJadwalForm.ShowDialog();
            this.Hide();
        }

        // Tombol untuk berpindah ke form edit jadwal
        private void button_EditJadwal_Click(object sender, EventArgs e)
        {
            var editJadwalForm = new EditJadwal();
            editJadwalForm.ShowDialog();
            this.Hide();
        }

        // Tombol untuk kembali ke beranda admin
        private void Beranda_Click(object sender, EventArgs e)
        {
            var beranda = new DashboardAdmin();
            beranda.Show();
            this.Hide();
        }

        // Klik ikon untuk validasi area
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var area = new MenuValidasiArea();
            area.Show();
            this.Hide();
        }

        // Klik ikon untuk validasi keuntungan
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var keuntungan = new MenuValidasiKeuntungan();
            keuntungan.Show();
            this.Hide();
        }

        // Klik ikon logout
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Tampilkan dialog konfirmasi keluar
            var result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Hapus sesi pengguna
                Session.Username = null;
                Session.Role = null;

                // Kembali ke form login
                var menuLogin = new MenuLogin();
                menuLogin.Show();

                this.Close(); // Tutup form saat ini
            }
        }
    }
}

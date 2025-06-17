using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_Regreen.Admin;

namespace View_Regreen.Menu
{
    public partial class HapusJadwal : Form
    {
        // HttpClient digunakan untuk mengirim request HTTP ke API
        private readonly HttpClient _httpClient = new();

        // Menyimpan data semua jadwal yang dimuat dari API
        private List<JadwalModel> _allJadwals = new();

        public HapusJadwal()
        {
            InitializeComponent();

            // Atur tema warna latar belakang form dan panel
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");

            // Register event handler
            this.Load += HapusJadwal_Load;
            btnHapus.Click += btnHapus_Click;
        }

        // Memuat data jadwal dari API saat form ditampilkan
        private async void HapusJadwal_Load(object sender, EventArgs e)
        {
            await LoadAllJadwalAsync();
        }

        // Mengambil semua jadwal dari endpoint API dan menampilkannya di DataGridView
        private async Task LoadAllJadwalAsync()
        {
            try
            {
                string url = "https://localhost:7277/api/jadwal_admin";
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var jsonString = await response.Content.ReadAsStringAsync();

                // Deserialisasi JSON tanpa memperhatikan case nama properti
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var jadwals = JsonSerializer.Deserialize<List<JadwalModel>>(jsonString, options);

                if (jadwals != null)
                {
                    _allJadwals = jadwals;
                    dataGridView1.DataSource = _allJadwals;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        // Menghapus jadwal berdasarkan tanggal yang dipilih dari DatePicker
        private async void btnHapus_Click(object sender, EventArgs e)
        {
            var selectedDate = dateTimePickerFilter.Value.Date;
            string namaKurir = txtNamaKurir.Text.Trim(); // pastikan txtNamaKurir sudah ada di form

            if (string.IsNullOrWhiteSpace(namaKurir))
            {
                MessageBox.Show("Nama kurir harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Yakin ingin menghapus jadwal pada {selectedDate:yyyy-MM-dd} untuk kurir '{namaKurir}'?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    string url = $"https://localhost:7277/api/jadwal_admin/{selectedDate:yyyy-MM-dd}/{namaKurir}";
                    var response = await _httpClient.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Jadwal berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadAllJadwalAsync(); // Refresh tampilan
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Jadwal tidak ditemukan.", "Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string errorMsg = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Gagal menghapus jadwal: {errorMsg}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Reset tampilan DataGridView ke semua data jadwal yang telah dimuat
        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _allJadwals;
        }

        // Event kosong – dapat dihapus jika tidak digunakan
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label_Text1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        // Navigasi ke Dashboard
        private void Beranda_Click(object sender, EventArgs e)
        {
            var dashboardAdminForm = new DashboardAdmin();
            dashboardAdminForm.Show();
            this.Hide();
        }

        // Navigasi ke Menu Penjadwalan
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var penjadwalan = new MenuPenjadwalan();
            penjadwalan.Show();
            this.Hide();
        }

        // Navigasi ke Menu Validasi Area
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var area = new MenuValidasiArea();
            area.Show();
            this.Hide();
        }

        // Navigasi ke Menu Validasi Keuntungan
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var keuntungan = new MenuValidasiKeuntungan();
            keuntungan.Show();
            this.Hide();
        }

        // Logout dari sistem dengan konfirmasi
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Session.Username = null;
                Session.Role = null;

                var menuLogin = new MenuLogin();
                menuLogin.Show();
                this.Close();
            }
        }

        // event
        private void Beranda_Click_1(object sender, EventArgs e) => Beranda_Click(sender, e);
        private void pictureBox3_Click_1(object sender, EventArgs e) => pictureBox3_Click(sender, e);
        private void pictureBox4_Click_1(object sender, EventArgs e) => pictureBox4_Click(sender, e);
        private void pictureBox2_Click_1(object sender, EventArgs e) => pictureBox2_Click(sender, e);
        private void pictureBox6_Click_1(object sender, EventArgs e) => pictureBox6_Click(sender, e);
    }
}

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
        // HttpClient digunakan untuk komunikasi HTTP dengan API
        private readonly HttpClient _httpClient = new();

        // Menyimpan semua jadwal yang telah dimuat dari API
        private List<JadwalModel> _allJadwals = new();

        // Konstruktor Form
        public HapusJadwal()
        {
            InitializeComponent();

            // Mengatur warna latar belakang form dan panel
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");

            // Menambahkan event handler untuk event load dan tombol hapus
            this.Load += HapusJadwal_Load;
            btnHapus.Click += btnHapus_Click;
        }

        // Event handler saat form dimuat
        private async void HapusJadwal_Load(object sender, EventArgs e)
        {
            // Memuat semua data jadwal dari API
            await LoadAllJadwalAsync();
        }

        // Fungsi untuk mengambil semua jadwal dari API
        private async Task LoadAllJadwalAsync()
        {
            try
            {
                string url = "https://localhost:7277/api/jadwal_admin";
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Memastikan status response adalah sukses

                var jsonString = await response.Content.ReadAsStringAsync();

                // Mengatur agar deserialisasi properti tidak case-sensitive
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                // Deserialisasi data JSON ke List<JadwalModel>
                var jadwals = JsonSerializer.Deserialize<List<JadwalModel>>(jsonString, options);

                if (jadwals != null)
                {
                    _allJadwals = jadwals;

                    // Menampilkan data ke dalam DataGridView
                    dataGridView1.DataSource = _allJadwals;
                }
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika terjadi exception
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        // Event handler tombol hapus jadwal berdasarkan tanggal yang dipilih
        private async void btnHapus_Click(object sender, EventArgs e)
        {
            // Ambil tanggal dari date picker
            var selectedDate = dateTimePickerFilter.Value.Date;

            // Konfirmasi penghapusan dari pengguna
            var confirmResult = MessageBox.Show(
                $"Yakin ingin menghapus jadwal pada {selectedDate:yyyy-MM-dd}?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo);

            // Jika user mengonfirmasi penghapusan
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Kirim request DELETE ke API berdasarkan tanggal
                    string url = $"https://localhost:7277/api/jadwal_admin/{selectedDate:yyyy-MM-dd}";
                    var response = await _httpClient.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        // Jika sukses, tampilkan pesan dan refresh data
                        MessageBox.Show("Jadwal berhasil dihapus.");
                        await LoadAllJadwalAsync();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        // Jika data tidak ditemukan
                        MessageBox.Show("Jadwal tidak ditemukan.");
                    }
                    else
                    {
                        // Menampilkan pesan kesalahan dari API
                        string errorMsg = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Gagal menghapus jadwal: " + errorMsg);
                    }
                }
                catch (Exception ex)
                {
                    // Tampilkan error umum
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        // Tombol untuk mengembalikan tampilan DataGridView ke semua data
        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _allJadwals;
        }

        // Event kosong jika ingin digunakan untuk klik isi cell DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        // Event kosong untuk label jika ingin digunakan kemudian
        private void label_Text1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void Beranda_Click(object sender, EventArgs e)
        {
            var dashboardAdminForm = new DashboardAdmin();
            dashboardAdminForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var penjadwalan = new MenuPenjadwalan();
            penjadwalan.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var area = new MenuValidasiArea();
            area.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var keuntungan = new MenuValidasiKeuntungan();
            keuntungan.Show();
            this.Hide();
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

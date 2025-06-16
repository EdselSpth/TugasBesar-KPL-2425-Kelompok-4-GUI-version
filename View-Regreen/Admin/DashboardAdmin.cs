using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_Regreen.Admin;

namespace View_Regreen.Menu
{
    public partial class DashboardAdmin : Form
    {
        // HttpClient untuk melakukan permintaan HTTP ke API
        private readonly HttpClient _httpClient = new();

        // Menyimpan semua data jadwal yang dimuat dari API
        private List<JadwalModel> _allJadwals = new();

        // Konstruktor form DashboardAdmin
        public DashboardAdmin()
        {
            InitializeComponent();

            // Mengatur warna latar belakang form dan panel
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");
        }

        // Event handler saat form dimuat
        private async void DashboardAdmin_Load(object sender, EventArgs e)
        {
            // Menampilkan pesan selamat datang dengan username dari session
            label1.Text = $"Selamat Datang, {Session.Username}";
            // Memuat data jadwal dari API secara asinkron
            await LoadAllJadwalAsync();
        }

        // Fungsi untuk mengambil dan memuat semua data jadwal dari API
        private async Task LoadAllJadwalAsync()
        {
            try
            {
                string url = "https://localhost:7277/api/jadwal_admin";

                // Mengirim permintaan GET ke API
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Menampilkan error jika status code bukan 2xx

                var jsonString = await response.Content.ReadAsStringAsync();

                // Opsi agar deserialisasi tidak case-sensitive
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Konversi JSON menjadi list JadwalModel
                var jadwals = JsonSerializer.Deserialize<List<JadwalModel>>(jsonString, options);

                if (jadwals != null)
                {
                    _allJadwals = jadwals;

                    // Tampilkan data ke DataGridView
                    dataGridView1.DataSource = _allJadwals;
                }
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika terjadi kesalahan
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        // Event handler untuk tombol filter berdasarkan tanggal
        private void btnFilterTanggal_Click(object sender, EventArgs e)
        {
            // Ambil tanggal yang dipilih dari DateTimePicker
            var selectedDate = dateTimePickerFilter.Value.Date;

            // Filter list jadwal berdasarkan tanggal
            var filteredJadwals = _allJadwals.FindAll(j => j.tanggal.Date == selectedDate);

            if (filteredJadwals.Count == 0)
            {
                MessageBox.Show("Tidak ada jadwal pada tanggal tersebut.");
            }

            // Tampilkan hasil filter ke DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filteredJadwals;
        }

        // Event handler untuk klik cell di DataGridView (belum digunakan)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        // Tombol reset filter, menampilkan semua data kembali
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _allJadwals;
        }

        // Navigasi ke menu penjadwalan ketika gambar (pictureBox2) diklik
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var menuPenjadwalan = new MenuPenjadwalan();
            menuPenjadwalan.Show();
            this.Hide(); // Sembunyikan form saat ini
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var menuValidasiArea = new MenuValidasiArea();
            menuValidasiArea.Show();
            this.Hide(); // Sembunyikan form saat ini
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var menuValidasiKeuntungan = new MenuValidasiKeuntungan();
            menuValidasiKeuntungan.Show();
            this.Hide(); // Sembunyikan form saat ini
        }

        private void Beranda_Click(object sender, EventArgs e)
        {
            var dashboard = new DashboardAdmin();
            dashboard.Show();
            this.Hide(); // Sembunyikan form saat ini
        }
    }

    // Model data untuk merepresentasikan struktur jadwal
    public class JadwalModel
    {
        public DateTime tanggal { get; set; }
        public List<string> jenisSampah { get; set; }
        public string namaKurir { get; set; }
        public string areaDiambil { get; set; }
        public string hari { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_Regreen.Admin;
using View_Regreen.User;

namespace View_Regreen.Menu
{
    public partial class DashboardUser : Form
    {
        private readonly HttpClient _httpClient = new();
        private List<JadwalModel> _allJadwals = new();

        public DashboardUser()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");
        }

        private async void DashboardUser_Load(object sender, EventArgs e)
        {
            label1.Text = $"Selamat Datang, {Session.Username}";
            await LoadAllJadwalAsync();
        }

        private async Task LoadAllJadwalAsync()
        {
            try
            {
                string url = "https://localhost:7277/api/jadwal_user";
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var jsonString = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

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

        private void btnFilterTanggal_Click(object sender, EventArgs e)
        {
            var selectedDate = dateTimePickerFilter.Value.Date;
            var filteredJadwals = _allJadwals.FindAll(j => j.tanggal.Date == selectedDate);

            if (filteredJadwals.Count == 0)
            {
                MessageBox.Show("Tidak ada jadwal pada tanggal tersebut.");
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filteredJadwals;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _allJadwals;
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
            var menuPenarikanKeuntungan = new MenuPenarikanKeuntungan();
            menuPenarikanKeuntungan.Show();
            this.Hide(); // Sembunyikan form saat ini
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var daftarAmbil = new MenuDaftarPengambilan();
            daftarAmbil.Show();
            this.Hide(); // Sembunyikan form saat ini
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var daftarArea = new MenuDaftarArea();
            daftarArea.Show();
            this.Hide(); // Sembunyikan form saat ini
        }
    }
}

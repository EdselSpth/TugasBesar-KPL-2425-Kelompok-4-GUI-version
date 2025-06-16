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
        private readonly HttpClient _httpClient = new();
        private List<JadwalAPI.Model.JadwalModel> _allJadwals = new();


        public MenuPenjadwalan()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");
        }

        private async Task LoadAllJadwalAsync()
        {
            try
            {
                string url = "https://localhost:7277/api/jadwal_admin";
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var jsonString = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var jadwals = JsonSerializer.Deserialize<List<JadwalAPI.Model.JadwalModel>>(jsonString, options);


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

        private async void MenuPenjadwalan_Load(object sender, EventArgs e)
        {
            await LoadAllJadwalAsync();
        }

        private void button_hapusJadwal_Click(object sender, EventArgs e)
        {
            var hapusJadwalForm = new HapusJadwal();
            hapusJadwalForm.ShowDialog();
            this.Hide();
        }

        private void button_TambahJadwal_Click(object sender, EventArgs e)
        {
            var tambahJadwalForm = new TambahJadwal();
            tambahJadwalForm.ShowDialog();
            this.Hide();
        }

        private void button_EditJadwal_Click(object sender, EventArgs e)
        {
            var editJadwalForm = new EditJadwal();
            editJadwalForm.ShowDialog();
            this.Hide();
        }

        private void Beranda_Click(object sender, EventArgs e)
        {
            var beranda = new DashboardAdmin();
            beranda.Show();
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

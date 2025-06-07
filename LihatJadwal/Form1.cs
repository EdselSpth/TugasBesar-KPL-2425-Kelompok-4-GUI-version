using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LihatJadwal
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new();
        private List<JadwalModel> _allJadwals = new List<JadwalModel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tidak load otomatis
        }

        private async void buttonLoadAll_Click(object sender, EventArgs e)
        {
            await LoadAllJadwalAsync();
        }

        private async void buttonSearchByDate_Click(object sender, EventArgs e)
        {
            var selectedDate = dateTimePicker1.Value.Date;
            await LoadJadwalByTanggalAsync(selectedDate);
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

        private async Task LoadJadwalByTanggalAsync(DateTime tanggal)
        {
            try
            {
                string url = $"https://localhost:7277/api/jadwal_admin/{tanggal:yyyy-MM-dd}";
                var response = await _httpClient.GetAsync(url);

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Jadwal untuk tanggal tersebut tidak ditemukan.");
                    dataGridView1.DataSource = null;
                    return;
                }

                response.EnsureSuccessStatusCode();

                var jsonString = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var jadwals = JsonSerializer.Deserialize<List<JadwalModel>>(jsonString, options);

                if (jadwals != null)
                {
                    dataGridView1.DataSource = jadwals;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }
    }

    public class JadwalModel
    {
        public DateTime tanggal { get; set; }
        public List<string> jenisSampah { get; set; }
        public string namaKurir { get; set; }
        public string areaDiambil { get; set; }
        public string hari { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View_Regreen.Menu
{
    public partial class DashboardAdmin : Form
    {
        private readonly HttpClient _httpClient = new();
        private List<JadwalModel> _allJadwals = new();

        public DashboardAdmin()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");
        }

        private async void DashboardAdmin_Load(object sender, EventArgs e)
        {
            await LoadAllJadwalAsync();
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

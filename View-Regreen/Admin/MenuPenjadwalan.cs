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
using JadwalAPI.Model;

namespace View_Regreen.Admin
{
    public partial class MenuPenjadwalan : Form
    {
        private readonly HttpClient _httpClient = new();
        private List<JadwalModel> _allJadwals = new();
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

        private void MenuPenjadwalan_Load(object sender, EventArgs e)
        {
            await LoadAllJadwalAsync();
        }
    }
}

using System;
using System.Windows.Forms;

namespace DeleteJadwal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DateTime tanggal = dateTimePicker2.Value.Date;

            var confirm = MessageBox.Show(
                $"Yakin ingin menghapus jadwal pada tanggal {tanggal:yyyy-MM-dd}?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Contoh endpoint API hapus jadwal, sesuaikan dengan API kamu
                    string url = $"https://localhost:7277/api/jadwal_admin/{tanggal:yyyy-MM-dd}";

                    using (var httpClient = new System.Net.Http.HttpClient())
                    {
                        var response = await httpClient.DeleteAsync(url);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Jadwal berhasil dihapus.");
                            await LoadAllJadwalAsync();
                        }
                        else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("Jadwal tidak ditemukan untuk tanggal tersebut.");
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus jadwal. Status code: " + response.StatusCode);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await LoadAllJadwalAsync();
        }

        private async System.Threading.Tasks.Task LoadAllJadwalAsync()
        {
            try
            {
                string url = "https://localhost:7277/api/jadwal_admin";
                using (var httpClient = new System.Net.Http.HttpClient())
                {
                    var response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();
                    var options = new System.Text.Json.JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    var data = System.Text.Json.JsonSerializer.Deserialize<System.Collections.Generic.List<JadwalModel>>(json, options);

                    dataGridView1.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadAllJadwalAsync();
        }
    }

    public class JadwalModel
    {
        public DateTime tanggal { get; set; }
        public System.Collections.Generic.List<string> jenisSampah { get; set; }
        public string namaKurir { get; set; }
        public string areaDiambil { get; set; }
        public string hari { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelLibrary;
using JadwalAPI;
using JadwalAPI.Model;
using System.Text.Json;
using TugasBesar_KPL_2425_Kelompok_4;
using View_Regreen.Menu;

namespace View_Regreen.Admin
{
    public partial class TambahJadwal : Form
    {
        public TambahJadwal()
        {
            InitializeComponent();
            comboBox_jenissampah.DataSource = Enum.GetValues(typeof(JenisSampah));
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");
        }

        private readonly HttpClient _httpClient = new();
        private List<JadwalModel> _allJadwals = new();

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

        private async void TambahJadwal_Load(object sender, EventArgs e)
        {
            await LoadAllJadwalAsync();

        }

        private void button_Tambah_Click(object sender, EventArgs e)
        {
            try
            {
                var tanggal = DateOnly.FromDateTime(dateTimePicker.Value);
                var namaKurir = textBox_namakurir.Text;
                var area = textBox_area.Text;

                if (comboBox_jenissampah.SelectedItem is not JenisSampah jenisSampah)
                {
                    MessageBox.Show("Pilih jenis sampah terlebih dahulu.");
                    return;
                }

                var jenisList = new List<JenisSampah> { jenisSampah };
                var jenisStringList = jenisList.Select(j => j.ToString()).ToList();

                var jadwal = JadwalFactory.BuatJadwal(
                    tanggal,
                    jenisStringList,
                    namaKurir,
                    area
                );

                TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule.JadwalService.CreateAndSendJadwal(
                    jadwal.Tanggal,
                    jenisList,
                    jadwal.KurirPengambil,
                    jadwal.AreaDiambil
                );

                MessageBox.Show("Jadwal berhasil dibuat dan dikirim ke API.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("[Terjadi kesalahan] " + ex.Message);
            }
        }

        private void Beranda_Click(object sender, EventArgs e)
        {
            var dashboard = new DashboardAdmin();
            dashboard.Show();
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

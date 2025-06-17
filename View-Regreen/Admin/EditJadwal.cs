using modelLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using JadwalAPI;
using TugasBesar_KPL_2425_Kelompok_4;
using View_Regreen.Menu;

namespace View_Regreen.Admin
{
    public partial class EditJadwal : Form
    {
        public EditJadwal()
        // Inisialisasi seluruh view
        {
            InitializeComponent();
            comboBox_jenissampah.DataSource = Enum.GetValues(typeof(JenisSampah));
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");
        }


        private void Beranda_Click(object sender, EventArgs e)
        // method untuk kembali ke beranda dari menu
        {
            var beranda = new DashboardAdmin();
            beranda.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        // method untuk ke jadwal
        {
            var jadwaAmbill = new MenuPenjadwalan();
            jadwaAmbill.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        // method untuk ke validasi area
        {
            var area = new MenuValidasiArea();
            area.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        // method untuk ke validasi keuntungan
        {
            var validasiKeuntungan = new MenuValidasiKeuntungan();
            validasiKeuntungan.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        // method untuk exit
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

        private void button_ubahJadwal_Click(object sender, EventArgs e)
        // method menangani handling ubah jadwal saat tekan tombol ubah jadwal
        {
            try
            {
                // Ambil jadwal yang mau diubah
                var tanggalAwal = DateOnly.FromDateTime(tanggalInputLama.Value);
                var namaKurirLama = kurirLama.Text.Trim();

                var jadwalLama = TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule.JadwalService.GetJadwalByKurirDanTanggal(namaKurirLama, tanggalAwal);
                if (jadwalLama == null)
                {
                    MessageBox.Show("Jadwal tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var tanggalBaru = DateOnly.FromDateTime(tanggalInputBaru.Value);
                var namaKurirBaru = KurirBaru.Text.Trim();
                var area = areaBaru.Text.Trim();
                var jenisSampahStr = comboBox_jenissampah.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(jenisSampahStr) || !Enum.TryParse<JenisSampah>(jenisSampahStr, out var jenisSampah))
                {
                    MessageBox.Show("Jenis sampah tidak valid atau belum dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update jadwal
                TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule.JadwalService.UpdateJadwal(tanggalAwal, new List<JenisSampah> { jenisSampah }, namaKurirBaru, area, namaKurirLama, tanggalBaru);

                
                MessageBox.Show("Jadwal berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

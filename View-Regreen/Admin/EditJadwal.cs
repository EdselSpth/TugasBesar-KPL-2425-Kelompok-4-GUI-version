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

namespace View_Regreen.Admin
{
    public partial class EditJadwal : Form
    {
        public EditJadwal()
        {
            InitializeComponent();
            comboBox_jenissampah.DataSource = Enum.GetValues(typeof(JenisSampah));
        }

        private void button__UbahJadwal_Click(object sender, EventArgs e)
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

                // Ambil input baru
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
                TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule.JadwalService.UpdateJadwal(tanggalAwal, new List<JenisSampah> { jenisSampah }, namaKurirBaru, area, namaKurirLama);

                MessageBox.Show("Jadwal berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}

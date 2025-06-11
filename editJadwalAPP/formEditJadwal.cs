using modelLibrary;
using TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule;

namespace editJadwalAPP
{
    public partial class formEditJadwal : Form
    {
        public formEditJadwal()
        {
            InitializeComponent();
            comboBox_jenissampah.DataSource = Enum.GetValues(typeof(JenisSampah));
        }

        private void button__UbahJadwal_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil jadwal yang mau diubah
                var tanggalAwal = DateOnly.FromDateTime(dateTimePicker1.Value);
                var namaKurirLama = textBox1.Text.Trim();

                var jadwalLama = JadwalService.GetJadwalByKurirDanTanggal(namaKurirLama, tanggalAwal);
                if (jadwalLama == null)
                {
                    MessageBox.Show("Jadwal tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ambil input baru
                var tanggalBaru = DateOnly.FromDateTime(dateTimePicker.Value);
                var namaKurirBaru = textBox_namakurir.Text.Trim();
                var area = textBox_area.Text.Trim();
                var jenisSampahStr = comboBox_jenissampah.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(jenisSampahStr) || !Enum.TryParse<JenisSampah>(jenisSampahStr, out var jenisSampah))
                {
                    MessageBox.Show("Jenis sampah tidak valid atau belum dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update jadwal
                JadwalService.UpdateJadwal(tanggalAwal, new List<JenisSampah> { jenisSampah }, namaKurirBaru, area, namaKurirLama);

                MessageBox.Show("Jadwal berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void formEditJadwal_Load(object sender, EventArgs e)
        {

        }
    }
}

using modelLibrary;
// Tambahkan alias di atas file:

using TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule;
namespace tambahJadwalApp
{
    public partial class formTambahJadwal : Form
    {
        public formTambahJadwal()
        {
            InitializeComponent();
            comboBox_jenissampah.DataSource = Enum.GetValues(typeof(JenisSampah));
        }

        private void button_TambahJadwal_Click(object sender, EventArgs e)
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

                var jadwal = modelLibrary.Jadwal.BuatJadwal(tanggal, jenisStringList, area, namaKurir);

                TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule.JadwalService.CreateAndSendJadwal(
                    jadwal.Tanggal,
                    jenisList,
                    jadwal.NamaKurir,
                    jadwal.AreaDiambil
                );

                OutputSistem.Text = "Jadwal berhasil dibuat dan dikirim ke API.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("[Terjadi kesalahan] " + ex.Message);
            }
        }

    }
}

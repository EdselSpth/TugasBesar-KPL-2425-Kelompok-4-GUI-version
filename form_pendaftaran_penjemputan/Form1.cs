using modelLibrary;
using TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule;

namespace form_pendaftaran_penjemputan
{
    public partial class Form1 : Form
    {
        private List<configPendaftaraanArea> daftarArea;
        public Form1()
        {
            InitializeComponent();
            LoadArea();
        }
        private void LoadArea()
        {
            var areaConfig = new configPendaftaraanArea();
            daftarArea = areaConfig.GetAllArea() ?? new List<configPendaftaraanArea>();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text.Trim();
            string inputArea = textBoxArea.Text.Trim();
            string inputTanggal = textBoxTanggal.Text.Trim();
            string keterangan = textBoxKeterangan.Text.Trim();

            // Validasi form kosong
            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(inputArea) ||
                string.IsNullOrEmpty(inputTanggal) || string.IsNullOrEmpty(keterangan))
            {
                MessageBox.Show("Semua kolom harus diisi.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi tanggal
            if (!DateTime.TryParse(inputTanggal, out DateTime tanggalJemput))
            {
                MessageBox.Show("Format tanggal tidak valid. Gunakan format yyyy-MM-dd.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var areaConfig = new configPendaftaraanArea();
            daftarArea = areaConfig.GetAllArea();

            //Validasi apabila daftar area kosong
            if (daftarArea == null || daftarArea.Count == 0)
            {
                MessageBox.Show("Daftar area kosong. Periksa file JSON area.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi area dari JSON
            var areaDipilih = daftarArea.FirstOrDefault(a =>a.area != null && a.area.Equals(inputArea, StringComparison.OrdinalIgnoreCase));

            //Pengecekan apabila file belum dibuat
            if (areaDipilih == null)
            {
                MessageBox.Show("Area tidak ditemukan dalam daftar. Harap masukkan nama area yang valid.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi jadwal sampah berdasarkan RulesJadwal
            var jenisYangValid = Enum.GetValues(typeof(JenisSampah))
                .Cast<JenisSampah>()
                .Where(js => RulesJadwal.pengambilanValidasi(js, tanggalJemput))
                .ToList();

            if (jenisYangValid.Count == 0)
            {
                MessageBox.Show("Tidak ada jenis sampah yang dijadwalkan untuk hari tersebut.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var pendaftaran = new configPendaftaranPenjemputan<string>
            {
                namaPengguna = nama,
                Area = areaDipilih,
                Jadwal = tanggalJemput,
                Keterangan = keterangan
            };

            pendaftaran.Simpan();
            MessageBox.Show("Pendaftaran berhasil disimpan!", "Sukses",MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxNama.Clear();
            textBoxArea.Clear();
            textBoxTanggal.Clear();
            textBoxKeterangan.Clear();
        }
    }
}

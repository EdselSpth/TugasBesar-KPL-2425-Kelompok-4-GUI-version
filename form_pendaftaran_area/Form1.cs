using TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule;

namespace form_pendaftaran_area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namaArea = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(namaArea))
            {
                MessageBox.Show("Nama area tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            configPendaftaraanArea areaConfig = new configPendaftaraanArea();
            var daftarArea = areaConfig.GetAllArea();

            bool sudahAda = false;

            foreach (var area in daftarArea)
            {
                if (area.area != null && area.area.Equals(namaArea, StringComparison.OrdinalIgnoreCase))
                {
                    sudahAda = true;
                    break;
                }
            }

            if (sudahAda)
            {
                MessageBox.Show("Area sudah terdaftar. Silakan masukkan nama area yang berbeda.", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
            }
            else
            {
                configPendaftaraanArea areaBaru = new configPendaftaraanArea
                {
                    area = namaArea
                };

                areaBaru.saveArea(); // panggil method asli, tanpa modifikasi
                MessageBox.Show("Area berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

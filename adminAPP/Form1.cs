using FormPenarikanKeuntungan;
using LihatJadwal;
using DeleteJadwal;
using tambahJadwalApp;

namespace adminAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_lihatJadwal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var penarikanForm = new FormPenarikanAdmin();
            penarikanForm.Show();
            this.Hide();
        }

        private void button_lihatJadwal_Click_1(object sender, EventArgs e)
        {
            var lihatJadwalForm = new Lihatjadwal();
            lihatJadwalForm.Show();
            this.Hide();
        }

        private void button_hapusJadwal_Click(object sender, EventArgs e)
        {
            var hapusJadwalForm = new HapusJadwal();
            hapusJadwalForm.Show();
            this.Hide();
        }

        private void button_tambahJadwal_Click(object sender, EventArgs e)
        {
            var tambahJadwalForm = new formTambahJadwal();
            tambahJadwalForm.Show();
            this.Hide();
        }
    }
}

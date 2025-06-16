using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_Regreen.Menu;

namespace View_Regreen.Admin
{
    public partial class MenuValidasiArea : Form
    {
        public MenuValidasiArea()
        {
            InitializeComponent();

            // Atur warna latar belakang form dan panel agar sesuai dengan tema aplikasi
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");
        }

        // Event handler saat form pertama kali dimuat
        private void MenuValidasiArea_Load(object sender, EventArgs e)
        {
            // Belum ada logika khusus saat load
        }

        // Navigasi kembali ke dashboard admin (beranda)
        private void Beranda_Click(object sender, EventArgs e)
        {
            var dashboard = new DashboardAdmin();
            dashboard.Show();
            this.Hide();
        }

        // Navigasi ke menu penjadwalan
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var penjadwalan = new MenuPenjadwalan();
            penjadwalan.Show();
            this.Hide();
        }

        // Navigasi ke menu validasi keuntungan
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var keuntungan = new MenuValidasiKeuntungan();
            keuntungan.Show();
            this.Hide();
        }

        // Event handler untuk aksi logout (ikon keluar diklik)
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Tampilkan konfirmasi kepada pengguna sebelum keluar
            var result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Hapus data sesi pengguna yang sedang login
                Session.Username = null;
                Session.Role = null;

                // Tampilkan kembali form login
                var menuLogin = new MenuLogin();
                menuLogin.Show();

                // Tutup form validasi area saat ini
                this.Close();
            }
        }
    }
}

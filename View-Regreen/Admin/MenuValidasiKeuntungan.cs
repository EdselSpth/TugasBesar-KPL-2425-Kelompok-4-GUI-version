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
    public partial class MenuValidasiKeuntungan : Form
    {
        public MenuValidasiKeuntungan()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
            panel_1.BackColor = ColorTranslator.FromHtml("#D6E6C4");
        }

        private void Beranda_Click(object sender, EventArgs e)
        {
            var dashboard = new DashboardAdmin();
            dashboard.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var penjadwalan = new MenuPenjadwalan();
            penjadwalan.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var area = new MenuValidasiArea();
            area.Show();
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

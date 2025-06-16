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

namespace View_Regreen.User
{
    public partial class MenuDaftarPengambilan : Form
    {
        public MenuDaftarPengambilan()
        {
            InitializeComponent();
        }

        private void Beranda_Click(object sender, EventArgs e)
        {
            var dashboardUser = new DashboardUser();
            dashboardUser.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var penarikanKeuntungan = new MenuPenarikanKeuntungan();
            penarikanKeuntungan.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var daftarArea = new MenuDaftarArea();
            daftarArea.Show();
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

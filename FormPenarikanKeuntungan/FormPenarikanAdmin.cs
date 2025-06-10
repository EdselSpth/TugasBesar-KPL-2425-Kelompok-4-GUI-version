using System;
using System.Windows.Forms;

namespace FormPenarikanKeuntungan
{
    public partial class FormPenarikanAdmin : Form
    {
        public FormPenarikanAdmin()
        {
            InitializeComponent();
        }

        private void BtnTerima_Click(object sender, EventArgs e)
        {
            if (listViewPengajuan.SelectedItems.Count > 0)
            {
                listViewPengajuan.SelectedItems[0].SubItems[4].Text = "Diterima";
                MessageBox.Show("Permintaan disetujui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silakan pilih salah satu pengajuan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnTolak_Click(object sender, EventArgs e)
        {
            if (listViewPengajuan.SelectedItems.Count > 0)
            {
                listViewPengajuan.SelectedItems[0].SubItems[4].Text = "Ditolak";
                MessageBox.Show("Permintaan ditolak.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silakan pilih salah satu pengajuan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

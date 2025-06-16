using System;
using System.Windows.Forms;

namespace FormPenarikanKeuntungan
{
    public partial class FormPenarikanAdmin : Form
    {
        public FormPenarikanAdmin()
        {
            InitializeComponent();
            MuatDataDummy();
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

        private void MuatDataDummy()
        {
            listViewPengajuan.Items.Add(new ListViewItem(new[] { "1", "Budi", "BRI", "Rp500.000", "Pending" }));
            listViewPengajuan.Items.Add(new ListViewItem(new[] { "2", "Sari", "BCA", "Rp1.000.000", "Pending" }));
            listViewPengajuan.Items.Add(new ListViewItem(new[] { "3", "Agus", "Mandiri", "Rp750.000", "Pending" }));
            listViewPengajuan.Items.Add(new ListViewItem(new[] { "4", "Rina", "BNI", "Rp300.000", "Pending" }));
        }
    }
}
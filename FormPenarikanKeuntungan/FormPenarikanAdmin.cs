using System;
using System.Windows.Forms;

namespace FormPenarikanKeuntungan
{
    public partial class FormPenarikanAdmin : Form
    {
        public FormPenarikanAdmin() // Konstruktor untuk inisialisasi form
        {
            InitializeComponent();
            MuatDataDummy(); // Memuat data dummy ke dalam ListView
        }

        private void BtnTerima_Click(object sender, EventArgs e) // Method untuk menerima pengajuan penarikan
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

        private void BtnTolak_Click(object sender, EventArgs e) // Method untuk menolak pengajuan penarikan
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
            var data = new List<string[]>
        {
             new[] { "1", "Budi", "BRI", "Rp500.000", "Pending" },
             new[] { "2", "Sari", "BCA", "Rp1.000.000", "Pending" },
             new[] { "3", "Agus", "Mandiri", "Rp750.000", "Pending" },
             new[] { "4", "Rina", "BNI", "Rp300.000", "Pending" }
         };

            foreach (var row in data)
            {
                listViewPengajuan.Items.Add(new ListViewItem(row));
            }
        }

    }
}
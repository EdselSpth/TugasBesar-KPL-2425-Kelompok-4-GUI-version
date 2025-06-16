using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View_Regreen.Admin
{
    public partial class MenuValidasiKeuntungan : Form
    {
        private DataGridView dgvPengajuan;

        public MenuValidasiKeuntungan()
        {
            InitializeComponent(); // Panggil dari Designer
            this.Size = new System.Drawing.Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Validasi Keuntungan";

            SetupDataGridView();    // Tambahkan tabel ke PanelDummy
            LoadDataDummy();        // Isi dengan data dummy
        }

        private void SetupDataGridView()
        {
            dgvPengajuan = new DataGridView();
            dgvPengajuan.Size = new System.Drawing.Size(900, 300);
            dgvPengajuan.Location = new System.Drawing.Point(50, 50);
            dgvPengajuan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPengajuan.ReadOnly = true;
            dgvPengajuan.AllowUserToAddRows = false;
            dgvPengajuan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPengajuan.ColumnCount = 6;
            dgvPengajuan.Columns[0].Name = "No";
            dgvPengajuan.Columns[1].Name = "Nama";
            dgvPengajuan.Columns[2].Name = "Nominal";
            dgvPengajuan.Columns[3].Name = "Nomor";
            dgvPengajuan.Columns[4].Name = "Metode";
            dgvPengajuan.Columns[5].Name = "Status";

            PanelDummy.Controls.Add(dgvPengajuan);
        }

        private void LoadDataDummy()
        {
            var data = new List<string[]>
            {
                new[] { "1", "Budi Santoso", "Rp150.000", "1239738290", "BCA", "Pending" },
                new[] { "2", "Ahmad Solihin", "Rp50.000", "1203239200", "Mandiri", "Pending" },
                new[] { "3", "Bagas Kopling", "Rp100.000", "21091288329", "Mandiri", "Pending" }
            };

            foreach (var row in data)
            {
                dgvPengajuan.Rows.Add(row);
            }
        }

        private void button1_ClickTerima(object sender, EventArgs e)
        {
            if (dgvPengajuan.SelectedRows.Count > 0)
            {
                string nama = dgvPengajuan.SelectedRows[0].Cells[1].Value.ToString();
                dgvPengajuan.SelectedRows[0].Cells[5].Value = "Diterima";

                MessageBox.Show($"Permintaan 1 oleh {nama} disetujui", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silakan pilih satu baris terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_ClickTolak(object sender, EventArgs e)
        {
            if (dgvPengajuan.SelectedRows.Count > 0)
            {
                dgvPengajuan.SelectedRows[0].Cells[5].Value = "Ditolak";
                MessageBox.Show("Permintaan ditolak.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silakan pilih satu baris terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_PaintValidasi(object sender, PaintEventArgs e)
        {
            // Optional logic
        }

        private void panel2_PaintListData(object sender, PaintEventArgs e)
        {
            // Optional logic
        }
    }
}

using System;
using System.Windows.Forms;

namespace FormPenarikanKeuntungan
{
    public partial class FormPenarikanAdmin : Form
    {
        private System.ComponentModel.IContainer components = null;
        private ListView listViewPengajuan;
        private ColumnHeader columnID;
        private ColumnHeader columnNama;
        private ColumnHeader columnBank;
        private ColumnHeader columnNominal;
        private ColumnHeader columnStatus;
        private Button btnTerima;
        private Button btnTolak;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listViewPengajuan = new ListView
            {
                FullRowSelect = true,
                GridLines = true,
                View = View.Details,
                Location = new System.Drawing.Point(40, 30),
                Size = new System.Drawing.Size(700, 250)
            };

            columnID = new ColumnHeader { Text = "ID", Width = 40 };
            columnNama = new ColumnHeader { Text = "Nama", Width = 150 };
            columnBank = new ColumnHeader { Text = "Bank", Width = 100 };
            columnNominal = new ColumnHeader { Text = "Nominal", Width = 150 };
            columnStatus = new ColumnHeader { Text = "Status", Width = 100 };

            listViewPengajuan.Columns.AddRange(new[] { columnID, columnNama, columnBank, columnNominal, columnStatus });

            btnTerima = new Button
            {
                Text = "Terima",
                Location = new System.Drawing.Point(220, 300),
                Size = new System.Drawing.Size(120, 30)
            };

            btnTolak = new Button
            {
                Text = "Tolak",
                Location = new System.Drawing.Point(380, 300),
                Size = new System.Drawing.Size(120, 30)
            };

            btnTerima.Click += BtnTerima_Click;
            btnTolak.Click += BtnTolak_Click;

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 360);
            Controls.Add(listViewPengajuan);
            Controls.Add(btnTerima);
            Controls.Add(btnTolak);
            Text = "Panel Admin - Verifikasi Penarikan";
        }
    }
}
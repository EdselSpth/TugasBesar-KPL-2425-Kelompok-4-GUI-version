using System; 
using System.Windows.Forms; 

namespace FormPenarikanKeuntungan 
{
    public partial class FormPenarikanAdmin : Form 
    {
        // Deklarasi variabel UI dan komponen.
        private System.ComponentModel.IContainer components = null;
        private ListView listViewPengajuan; // ListView untuk menampilkan daftar pengajuan penarikan.
        private ColumnHeader columnID;      // Kolom untuk ID pengajuan.
        private ColumnHeader columnNama;    // Kolom untuk nama pengguna.
        private ColumnHeader columnBank;    // Kolom untuk nama bank.
        private ColumnHeader columnNominal; // Kolom untuk nominal penarikan.
        private ColumnHeader columnStatus;  // Kolom untuk status pengajuan.
        private Button btnTerima;           // Tombol untuk menerima pengajuan.
        private Button btnTolak;            // Tombol untuk menolak pengajuan.

        // Method untuk membebaskan resource jika form ditutup.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) // Jika disposing true dan komponen ada,
            {
                components.Dispose(); 
            }
            base.Dispose(disposing); // Panggil method Dispose dari base class.
        }

        // Method untuk menginisialisasi komponen UI pada form.
        private void InitializeComponent()
        {
            // Inisialisasi ListView dan pengaturannya.
            listViewPengajuan = new ListView
            {
                FullRowSelect = true, // Memungkinkan satu baris penuh dipilih.
                GridLines = true,     
                View = View.Details,  
                Location = new System.Drawing.Point(40, 30), 
                Size = new System.Drawing.Size(700, 250)     
            };

            // Inisialisasi kolom-kolom pada ListView.
            columnID = new ColumnHeader { Text = "ID", Width = 40 };
            columnNama = new ColumnHeader { Text = "Nama", Width = 150 };
            columnBank = new ColumnHeader { Text = "Bank", Width = 100 };
            columnNominal = new ColumnHeader { Text = "Nominal", Width = 150 };
            columnStatus = new ColumnHeader { Text = "Status", Width = 100 };

            // Menambahkan kolom-kolom ke dalam ListView.
            listViewPengajuan.Columns.AddRange(new[] { columnID, columnNama, columnBank, columnNominal, columnStatus });

            // Inisialisasi tombol "Terima".
            btnTerima = new Button
            {
                Text = "Terima", // Teks pada tombol.
                Location = new System.Drawing.Point(220, 300), // Lokasi tombol.
                Size = new System.Drawing.Size(120, 30)         // Ukuran tombol.
            };

            // Inisialisasi tombol "Tolak".
            btnTolak = new Button
            {
                Text = "Tolak",
                Location = new System.Drawing.Point(380, 300),
                Size = new System.Drawing.Size(120, 30)
            };

            // Event handler ketika tombol diklik.
            btnTerima.Click += BtnTerima_Click; // Method yang akan dipanggil saat tombol "Terima" diklik.
            btnTolak.Click += BtnTolak_Click;   // Method yang akan dipanggil saat tombol "Tolak" diklik.

            // Pengaturan ukuran form dan komponen yang ditampilkan.
            AutoScaleMode = AutoScaleMode.Font; 
            ClientSize = new System.Drawing.Size(800, 360); 
            Controls.Add(listViewPengajuan); // Tambahkan ListView ke dalam form.
            Controls.Add(btnTerima);         // Tambahkan tombol "Terima".
            Controls.Add(btnTolak);          // Tambahkan tombol "Tolak".
            Text = "Panel Admin - Verifikasi Penarikan"; 
        }
    }
}

namespace adminAPP
{
    partial class FormAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button_tambahJadwal = new Button();
            button_hapusJadwal = new Button();
            button_lihatJadwal = new Button();
            button_keuntungan = new Button();
            button_EditJadwal = new Button();
            button_Keluar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 32);
            label1.Name = "label1";
            label1.Size = new Size(285, 28);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang, di Fitur Admin";
            // 
            // button_tambahJadwal
            // 
            button_tambahJadwal.Location = new Point(39, 73);
            button_tambahJadwal.Name = "button_tambahJadwal";
            button_tambahJadwal.Size = new Size(726, 55);
            button_tambahJadwal.TabIndex = 1;
            button_tambahJadwal.Text = "Tambah Jadwal Pengambilan Sampah";
            button_tambahJadwal.UseVisualStyleBackColor = true;
            // 
            // button_hapusJadwal
            // 
            button_hapusJadwal.Location = new Point(40, 203);
            button_hapusJadwal.Name = "button_hapusJadwal";
            button_hapusJadwal.Size = new Size(725, 63);
            button_hapusJadwal.TabIndex = 2;
            button_hapusJadwal.Text = "Hapus Jadwal Pengambilan Sampah";
            button_hapusJadwal.UseVisualStyleBackColor = true;
            // 
            // button_lihatJadwal
            // 
            button_lihatJadwal.Location = new Point(40, 272);
            button_lihatJadwal.Name = "button_lihatJadwal";
            button_lihatJadwal.Size = new Size(725, 63);
            button_lihatJadwal.TabIndex = 3;
            button_lihatJadwal.Text = "Lihat Jadwal Pengambilan Sampah";
            button_lihatJadwal.UseVisualStyleBackColor = true;
            // 
            // button_keuntungan
            // 
            button_keuntungan.Location = new Point(40, 341);
            button_keuntungan.Name = "button_keuntungan";
            button_keuntungan.Size = new Size(725, 63);
            button_keuntungan.TabIndex = 4;
            button_keuntungan.Text = "Validasi Penarikan Keuntungan";
            button_keuntungan.UseVisualStyleBackColor = true;
            // 
            // button_EditJadwal
            // 
            button_EditJadwal.Location = new Point(40, 134);
            button_EditJadwal.Name = "button_EditJadwal";
            button_EditJadwal.Size = new Size(725, 63);
            button_EditJadwal.TabIndex = 5;
            button_EditJadwal.Text = "Edit Jadwal Pengambilan Sampah";
            button_EditJadwal.UseVisualStyleBackColor = true;
            // 
            // button_Keluar
            // 
            button_Keluar.Location = new Point(663, 32);
            button_Keluar.Name = "button_Keluar";
            button_Keluar.Size = new Size(102, 28);
            button_Keluar.TabIndex = 6;
            button_Keluar.Text = "Keluar";
            button_Keluar.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Keluar);
            Controls.Add(button_EditJadwal);
            Controls.Add(button_keuntungan);
            Controls.Add(button_lihatJadwal);
            Controls.Add(button_hapusJadwal);
            Controls.Add(button_tambahJadwal);
            Controls.Add(label1);
            Name = "FormAdmin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_tambahJadwal;
        private Button button_hapusJadwal;
        private Button button_lihatJadwal;
        private Button button_keuntungan;
        private Button button_EditJadwal;
        private Button button_Keluar;
    }
}

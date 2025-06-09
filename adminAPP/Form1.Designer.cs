namespace adminAPP
{
    partial class Form1
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
            button1 = new Button();
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
            button_tambahJadwal.Location = new Point(40, 87);
            button_tambahJadwal.Name = "button_tambahJadwal";
            button_tambahJadwal.Size = new Size(417, 55);
            button_tambahJadwal.TabIndex = 1;
            button_tambahJadwal.Text = "Tambah Jadwal Pengambilan Sampah";
            button_tambahJadwal.UseVisualStyleBackColor = true;
            // 
            // button_hapusJadwal
            // 
            button_hapusJadwal.Location = new Point(40, 148);
            button_hapusJadwal.Name = "button_hapusJadwal";
            button_hapusJadwal.Size = new Size(417, 63);
            button_hapusJadwal.TabIndex = 2;
            button_hapusJadwal.Text = "Hapus Jadwal Pengambilan Sampah";
            button_hapusJadwal.UseVisualStyleBackColor = true;
            // 
            // button_lihatJadwal
            // 
            button_lihatJadwal.Location = new Point(40, 217);
            button_lihatJadwal.Name = "button_lihatJadwal";
            button_lihatJadwal.Size = new Size(417, 63);
            button_lihatJadwal.TabIndex = 3;
            button_lihatJadwal.Text = "Lihat Jadwal Pengambilan Sampah";
            button_lihatJadwal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(39, 286);
            button1.Name = "button1";
            button1.Size = new Size(417, 63);
            button1.TabIndex = 4;
            button1.Text = "Validasi Penarikan Keuntungan";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button_lihatJadwal);
            Controls.Add(button_hapusJadwal);
            Controls.Add(button_tambahJadwal);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_tambahJadwal;
        private Button button_hapusJadwal;
        private Button button_lihatJadwal;
        private Button button1;
    }
}

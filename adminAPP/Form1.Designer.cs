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
            label1.Location = new Point(34, 24);
            label1.Name = "label1";
            label1.Size = new Size(226, 21);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang, di Fitur Admin";
            // 
            // button_tambahJadwal
            // 
            button_tambahJadwal.Location = new Point(35, 65);
            button_tambahJadwal.Margin = new Padding(3, 2, 3, 2);
            button_tambahJadwal.Name = "button_tambahJadwal";
            button_tambahJadwal.Size = new Size(365, 41);
            button_tambahJadwal.TabIndex = 1;
            button_tambahJadwal.Text = "Tambah Jadwal Pengambilan Sampah";
            button_tambahJadwal.UseVisualStyleBackColor = true;
            button_tambahJadwal.Click += button_tambahJadwal_Click;
            // 
            // button_hapusJadwal
            // 
            button_hapusJadwal.Location = new Point(35, 111);
            button_hapusJadwal.Margin = new Padding(3, 2, 3, 2);
            button_hapusJadwal.Name = "button_hapusJadwal";
            button_hapusJadwal.Size = new Size(365, 47);
            button_hapusJadwal.TabIndex = 2;
            button_hapusJadwal.Text = "Hapus Jadwal Pengambilan Sampah";
            button_hapusJadwal.UseVisualStyleBackColor = true;
            button_hapusJadwal.Click += button_hapusJadwal_Click;
            // 
            // button_lihatJadwal
            // 
            button_lihatJadwal.Location = new Point(35, 163);
            button_lihatJadwal.Margin = new Padding(3, 2, 3, 2);
            button_lihatJadwal.Name = "button_lihatJadwal";
            button_lihatJadwal.Size = new Size(365, 47);
            button_lihatJadwal.TabIndex = 3;
            button_lihatJadwal.Text = "Lihat Jadwal Pengambilan Sampah";
            button_lihatJadwal.UseVisualStyleBackColor = true;
            button_lihatJadwal.Click += button_lihatJadwal_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(34, 214);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(365, 47);
            button1.TabIndex = 4;
            button1.Text = "Validasi Penarikan Keuntungan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(button_lihatJadwal);
            Controls.Add(button_hapusJadwal);
            Controls.Add(button_tambahJadwal);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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

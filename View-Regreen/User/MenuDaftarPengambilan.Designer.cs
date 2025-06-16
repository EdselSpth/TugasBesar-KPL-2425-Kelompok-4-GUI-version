namespace View_Regreen.User
{
    partial class MenuDaftarPengambilan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            Beranda = new PictureBox();
            pictureBox1 = new PictureBox();
            label_Text1 = new Label();
            label_Text2 = new Label();
            label1 = new Label();
            comboBoxArea = new ComboBox();
            label2 = new Label();
            dateTimePickerTanggal = new DateTimePicker();
            listBoxJenisSampah = new ListBox();
            label3 = new Label();
            label4 = new Label();
            txtKeterangan = new TextBox();
            btnDaftar = new Button();
            label5 = new Label();
            txtNamaPengguna = new TextBox();
            panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_1
            // 
            panel_1.BackColor = SystemColors.ButtonHighlight;
            panel_1.Controls.Add(pictureBox4);
            panel_1.Controls.Add(pictureBox3);
            panel_1.Controls.Add(pictureBox2);
            panel_1.Controls.Add(pictureBox6);
            panel_1.Controls.Add(Beranda);
            panel_1.Controls.Add(pictureBox1);
            panel_1.Location = new Point(0, 0);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(261, 913);
            panel_1.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.User_Daftar_Area;
            pictureBox4.Location = new Point(18, 388);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(227, 71);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.User_Narik_Keuntungan;
            pictureBox3.Location = new Point(18, 312);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(227, 71);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.User_Daftar_Ambil_Sampah_OFF;
            pictureBox2.Location = new Point(18, 236);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(227, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Keluar;
            pictureBox6.Location = new Point(18, 841);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(97, 52);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // Beranda
            // 
            Beranda.Image = Properties.Resources.Beranda_Menu_OFF;
            Beranda.Location = new Point(18, 160);
            Beranda.Name = "Beranda";
            Beranda.Size = new Size(227, 71);
            Beranda.SizeMode = PictureBoxSizeMode.Zoom;
            Beranda.TabIndex = 4;
            Beranda.TabStop = false;
            Beranda.Click += Beranda_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Regreen;
            pictureBox1.Location = new Point(18, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label_Text1
            // 
            label_Text1.AutoSize = true;
            label_Text1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Text1.Location = new Point(487, 61);
            label_Text1.Name = "label_Text1";
            label_Text1.RightToLeft = RightToLeft.Yes;
            label_Text1.Size = new Size(681, 54);
            label_Text1.TabIndex = 4;
            label_Text1.Text = "Pendaftaran Penjemputan Sampah";
            // 
            // label_Text2
            // 
            label_Text2.AutoSize = true;
            label_Text2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Text2.Location = new Point(312, 135);
            label_Text2.Name = "label_Text2";
            label_Text2.Size = new Size(301, 31);
            label_Text2.TabIndex = 6;
            label_Text2.Text = "Masukan Data Penjemputan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 244);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 7;
            label1.Text = "Daftar Area";
            // 
            // comboBoxArea
            // 
            comboBoxArea.FormattingEnabled = true;
            comboBoxArea.Location = new Point(754, 236);
            comboBoxArea.Name = "comboBoxArea";
            comboBoxArea.Size = new Size(250, 28);
            comboBoxArea.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 299);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 9;
            label2.Text = "Tanggal";
            // 
            // dateTimePickerTanggal
            // 
            dateTimePickerTanggal.Location = new Point(754, 292);
            dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            dateTimePickerTanggal.Size = new Size(250, 27);
            dateTimePickerTanggal.TabIndex = 10;
            dateTimePickerTanggal.ValueChanged += dateTimePickerTanggal_ValueChanged;
            // 
            // listBoxJenisSampah
            // 
            listBoxJenisSampah.FormattingEnabled = true;
            listBoxJenisSampah.Location = new Point(754, 353);
            listBoxJenisSampah.Name = "listBoxJenisSampah";
            listBoxJenisSampah.Size = new Size(150, 104);
            listBoxJenisSampah.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 353);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 12;
            label3.Text = "Jenis Sampah";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 490);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 13;
            label4.Text = "Keterangan";
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(754, 487);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(250, 27);
            txtKeterangan.TabIndex = 14;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.SeaGreen;
            btnDaftar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.ForeColor = Color.Transparent;
            btnDaftar.Location = new Point(631, 591);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(188, 43);
            btnDaftar.TabIndex = 16;
            btnDaftar.Text = "SUBMIT";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(495, 194);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 17;
            label5.Text = "Nama Pengguna";
            // 
            // txtNamaPengguna
            // 
            txtNamaPengguna.Location = new Point(754, 187);
            txtNamaPengguna.Name = "txtNamaPengguna";
            txtNamaPengguna.Size = new Size(250, 27);
            txtNamaPengguna.TabIndex = 18;
            // 
            // MenuDaftarPengambilan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(txtNamaPengguna);
            Controls.Add(label5);
            Controls.Add(btnDaftar);
            Controls.Add(txtKeterangan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBoxJenisSampah);
            Controls.Add(dateTimePickerTanggal);
            Controls.Add(label2);
            Controls.Add(comboBoxArea);
            Controls.Add(label1);
            Controls.Add(label_Text2);
            Controls.Add(label_Text1);
            Controls.Add(panel_1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuDaftarPengambilan";
            Text = "MenuDaftarPengambilan";
            Load += MenuDaftarPengambilan_Load;
            panel_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox Beranda;
        private PictureBox pictureBox1;
        private Label label_Text1;
        private Label label_Text2;
        private Label label1;
        private ComboBox comboBoxArea;
        private Label label2;
        private DateTimePicker dateTimePickerTanggal;
        private ListBox listBoxJenisSampah;
        private Label label3;
        private Label label4;
        private TextBox txtKeterangan;
        private Button btnDaftar;
        private Label label5;
        private TextBox txtNamaPengguna;
    }
}
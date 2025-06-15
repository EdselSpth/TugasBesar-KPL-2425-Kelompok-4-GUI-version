namespace View_Regreen.Admin
{
    partial class MenuPenjadwalan
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
            Panel_Header = new Panel();
            panelTableContainer = new Panel();
            dataGridView1 = new DataGridView();
            button_TambahJadwal = new Button();
            button_EditJadwal = new Button();
            button3 = new Button();
            panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Panel_Header.SuspendLayout();
            panelTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel_1.Margin = new Padding(3, 2, 3, 2);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(228, 685);
            panel_1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Penarikan_Menu_OFF;
            pictureBox4.Location = new Point(16, 291);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(199, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Area_Menu_OFF;
            pictureBox3.Location = new Point(16, 234);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Penjadwalan_Menu;
            pictureBox2.Location = new Point(16, 177);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Keluar;
            pictureBox6.Location = new Point(16, 631);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(85, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // Beranda
            // 
            Beranda.Image = Properties.Resources.Beranda_Menu_OFF;
            Beranda.Location = new Point(16, 120);
            Beranda.Margin = new Padding(3, 2, 3, 2);
            Beranda.Name = "Beranda";
            Beranda.Size = new Size(199, 53);
            Beranda.SizeMode = PictureBoxSizeMode.Zoom;
            Beranda.TabIndex = 4;
            Beranda.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Regreen;
            pictureBox1.Location = new Point(16, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label_Text1
            // 
            label_Text1.AutoSize = true;
            label_Text1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Text1.ForeColor = SystemColors.ButtonHighlight;
            label_Text1.Location = new Point(23, 17);
            label_Text1.Name = "label_Text1";
            label_Text1.Size = new Size(487, 32);
            label_Text1.TabIndex = 0;
            label_Text1.Text = "PENJADWALAN PENGAMBILAN SAMPAH";
            // 
            // Panel_Header
            // 
            Panel_Header.BackColor = Color.SeaGreen;
            Panel_Header.Controls.Add(label_Text1);
            Panel_Header.Location = new Point(229, 0);
            Panel_Header.Name = "Panel_Header";
            Panel_Header.Size = new Size(1037, 69);
            Panel_Header.TabIndex = 6;
            // 
            // panelTableContainer
            // 
            panelTableContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTableContainer.BackColor = SystemColors.Window;
            panelTableContainer.Controls.Add(dataGridView1);
            panelTableContainer.Location = new Point(266, 120);
            panelTableContainer.Margin = new Padding(3, 2, 3, 2);
            panelTableContainer.Name = "panelTableContainer";
            panelTableContainer.Size = new Size(964, 380);
            panelTableContainer.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(964, 380);
            dataGridView1.TabIndex = 0;
            // 
            // button_TambahJadwal
            // 
            button_TambahJadwal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_TambahJadwal.Location = new Point(268, 529);
            button_TambahJadwal.Name = "button_TambahJadwal";
            button_TambahJadwal.Size = new Size(290, 64);
            button_TambahJadwal.TabIndex = 8;
            button_TambahJadwal.Text = "Tambah Jadwal";
            button_TambahJadwal.UseVisualStyleBackColor = true;
            // 
            // button_EditJadwal
            // 
            button_EditJadwal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_EditJadwal.Location = new Point(600, 529);
            button_EditJadwal.Name = "button_EditJadwal";
            button_EditJadwal.Size = new Size(290, 64);
            button_EditJadwal.TabIndex = 9;
            button_EditJadwal.Text = "Edit Jadwal";
            button_EditJadwal.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(940, 529);
            button3.Name = "button3";
            button3.Size = new Size(290, 64);
            button3.TabIndex = 10;
            button3.Text = "Hapus Jadwal";
            button3.UseVisualStyleBackColor = true;
            // 
            // MenuPenjadwalan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(button3);
            Controls.Add(button_EditJadwal);
            Controls.Add(button_TambahJadwal);
            Controls.Add(panelTableContainer);
            Controls.Add(Panel_Header);
            Controls.Add(panel_1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPenjadwalan";
            Text = "MenuPenjadwalan";
            Load += MenuPenjadwalan_Load;
            panel_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Panel_Header.ResumeLayout(false);
            Panel_Header.PerformLayout();
            panelTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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
        private Panel Panel_Header;
        private Panel panelTableContainer;
        private DataGridView dataGridView1;
        private Button button_TambahJadwal;
        private Button button_EditJadwal;
        private Button button3;
    }
}
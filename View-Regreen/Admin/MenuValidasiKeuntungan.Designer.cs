namespace View_Regreen.Admin
{
    partial class MenuValidasiKeuntungan
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
            ValidasiPenarikanKeuntungan = new Panel();
            PanelDummy = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            panel_1.Margin = new Padding(4, 3, 4, 3);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(326, 1143);
            panel_1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Tarik_Untung_Menu;
            pictureBox4.Location = new Point(23, 485);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(284, 87);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Area_Menu_OFF;
            pictureBox3.Location = new Point(23, 390);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(284, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Penjadwalan_Menu_OFF1;
            pictureBox2.Location = new Point(23, 295);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Keluar;
            pictureBox6.Location = new Point(23, 1053);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(121, 65);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // Beranda
            // 
            Beranda.Image = Properties.Resources.Beranda_Menu_OFF;
            Beranda.Location = new Point(23, 200);
            Beranda.Margin = new Padding(4, 3, 4, 3);
            Beranda.Name = "Beranda";
            Beranda.Size = new Size(284, 87);
            Beranda.SizeMode = PictureBoxSizeMode.Zoom;
            Beranda.TabIndex = 4;
            Beranda.TabStop = false;
            Beranda.Click += Beranda_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Regreen;
            pictureBox1.Location = new Point(23, 23);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ValidasiPenarikanKeuntungan
            // 
            ValidasiPenarikanKeuntungan.Location = new Point(321, 0);
            ValidasiPenarikanKeuntungan.Name = "ValidasiPenarikanKeuntungan";
            ValidasiPenarikanKeuntungan.Size = new Size(0, 0);
            ValidasiPenarikanKeuntungan.TabIndex = 2;
            ValidasiPenarikanKeuntungan.Paint += panel1_PaintValidasi;
            // 
            // PanelDummy
            // 
            PanelDummy.Location = new Point(359, 137);
            PanelDummy.Name = "PanelDummy";
            PanelDummy.Size = new Size(1390, 673);
            PanelDummy.TabIndex = 3;
            PanelDummy.Paint += panel2_PaintListData;
            // 
            // button2
            // 

            button2.Name = "button2";
            button2.Size = new Size(246, 103);
            button2.TabIndex = 1;
            button2.Text = "Tolak";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_ClickTolak;
            // 
            // button1
            // 

            button1.Name = "button1";
            button1.Size = new Size(257, 103);
            button1.TabIndex = 0;
            button1.Text = "Terima";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_ClickTerima;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(321, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1486, 113);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(37, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(653, 48);
            label1.TabIndex = 0;
            label1.Text = "VALIDASI PENARIKAN KEUNTUNGAN";
            // 
            // MenuValidasiKeuntungan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1806, 1050);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PanelDummy);
            Controls.Add(ValidasiPenarikanKeuntungan);
            Controls.Add(panel_1);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "MenuValidasiKeuntungan";
            Text = "MenuValidasiKeuntungan";
            Load += MenuValidasiKeuntungan_Load_1;
            panel_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel Panel_Header;
        private Label label_Text1;
        private Panel ValidasiPenarikanKeuntungan;
        private Panel PanelDummy;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label1;
    }
}
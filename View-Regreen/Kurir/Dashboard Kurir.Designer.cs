namespace View_Regreen.Kurir
{
    partial class Dashboard_Kurir
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
            pictureBox6 = new PictureBox();
            Beranda = new PictureBox();
            pictureBox1 = new PictureBox();
            panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_1
            // 
            panel_1.BackColor = SystemColors.ButtonHighlight;
            panel_1.Controls.Add(pictureBox6);
            panel_1.Controls.Add(Beranda);
            panel_1.Controls.Add(pictureBox1);
            panel_1.Location = new Point(0, 0);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(215, 453);
            panel_1.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Keluar;
            pictureBox6.Location = new Point(18, 399);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(101, 27);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // Beranda
            // 
            Beranda.Image = Properties.Resources.Beranda_Menu;
            Beranda.Location = new Point(16, 113);
            Beranda.Name = "Beranda";
            Beranda.Size = new Size(185, 48);
            Beranda.SizeMode = PictureBoxSizeMode.Zoom;
            Beranda.TabIndex = 1;
            Beranda.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Regreen;
            pictureBox1.Location = new Point(18, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Dashboard_Kurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_1);
            Name = "Dashboard_Kurir";
            Text = "Dashboard_Kurir";
            panel_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_1;
        private PictureBox pictureBox6;
        private PictureBox Beranda;
        private PictureBox pictureBox1;
    }
}
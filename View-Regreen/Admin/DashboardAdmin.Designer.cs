namespace View_Regreen.Menu
{
    partial class DashboardAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel_1 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            Beranda = new PictureBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            dateTimePickerFilter = new DateTimePicker();
            btnFilterTanggal = new Button();

            panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();

            // panel_1
            panel_1.BackColor = SystemColors.ButtonHighlight;
            panel_1.Controls.Add(pictureBox6);
            panel_1.Controls.Add(pictureBox5);
            panel_1.Controls.Add(pictureBox4);
            panel_1.Controls.Add(pictureBox3);
            panel_1.Controls.Add(Beranda);
            panel_1.Controls.Add(pictureBox1);
            panel_1.Location = new Point(0, 0);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(215, 673);
            panel_1.TabIndex = 0;

            // pictureBox6
            pictureBox6.Image = Properties.Resources.Keluar;
            pictureBox6.Location = new Point(16, 625);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(101, 27);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabStop = false;

            // pictureBox5
            pictureBox5.Image = Properties.Resources.Penarikan_Menu_OFF;
            pictureBox5.Location = new Point(16, 275);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(185, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabStop = false;

            // pictureBox4
            pictureBox4.Image = Properties.Resources.Area_Menu_OFF;
            pictureBox4.Location = new Point(16, 221);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(185, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabStop = false;

            // pictureBox3
            pictureBox3.Image = Properties.Resources.Penjadwalan_Menu_OFF1;
            pictureBox3.Location = new Point(16, 167);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(185, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabStop = false;

            // Beranda
            Beranda.Image = Properties.Resources.Beranda_Menu;
            Beranda.Location = new Point(16, 113);
            Beranda.Name = "Beranda";
            Beranda.Size = new Size(185, 48);
            Beranda.SizeMode = PictureBoxSizeMode.Zoom;
            Beranda.TabStop = false;

            // pictureBox1
            pictureBox1.Image = Properties.Resources.Logo_Regreen;
            pictureBox1.Location = new Point(18, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabStop = false;

            // dataGridView1
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(240, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(995, 367);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(240, 77);
            label1.Name = "label1";
            label1.Size = new Size(336, 31);
            label1.Text = "Jadwal Pengambilan Terdaftar";

            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(240, 521);
            label2.Name = "label2";
            label2.Size = new Size(202, 31);
            label2.Text = "Cari Pengambilan";

            // dateTimePickerFilter
            dateTimePickerFilter.Location = new Point(240, 567);
            dateTimePickerFilter.Name = "dateTimePickerFilter";
            dateTimePickerFilter.Size = new Size(263, 27);

            // btnFilterTanggal
            btnFilterTanggal.Location = new Point(240, 616);
            btnFilterTanggal.Name = "btnFilterTanggal";
            btnFilterTanggal.Size = new Size(204, 33);
            btnFilterTanggal.Text = "Cari";
            btnFilterTanggal.UseVisualStyleBackColor = true;
            btnFilterTanggal.Click += btnFilterTanggal_Click;

            // DashboardAdmin
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnFilterTanggal);
            Controls.Add(dateTimePickerFilter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel_1);
            Name = "DashboardAdmin";
            Text = "Dashboard Admin";
            Load += DashboardAdmin_Load;

            panel_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox Beranda;
        private PictureBox pictureBox6;
        private DataGridView dataGridView1;
        private Label label1;
        private BindingSource bindingSource1;
        private Label label2;
        private DateTimePicker dateTimePickerFilter;
        private Button btnFilterTanggal;
    }
}

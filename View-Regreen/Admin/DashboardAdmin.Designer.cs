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
            Beranda = new PictureBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            dateTimePickerFilter = new DateTimePicker();
            btnFilterTanggal = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            panel_1.TabIndex = 0;
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
            Beranda.Image = Properties.Resources.Beranda_Menu;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(291, 85);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(871, 275);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(291, 49);
            label1.Name = "label1";
            label1.Size = new Size(279, 25);
            label1.TabIndex = 3;
            label1.Text = "Jadwal Pengambilan Terdaftar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(291, 392);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 2;
            label2.Text = "Cari Pengambilan";
            // 
            // dateTimePickerFilter
            // 
            dateTimePickerFilter.Location = new Point(291, 426);
            dateTimePickerFilter.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerFilter.Name = "dateTimePickerFilter";
            dateTimePickerFilter.Size = new Size(231, 23);
            dateTimePickerFilter.TabIndex = 1;
            // 
            // btnFilterTanggal
            // 
            btnFilterTanggal.Location = new Point(291, 463);
            btnFilterTanggal.Margin = new Padding(3, 2, 3, 2);
            btnFilterTanggal.Name = "btnFilterTanggal";
            btnFilterTanggal.Size = new Size(178, 25);
            btnFilterTanggal.TabIndex = 0;
            btnFilterTanggal.Text = "Cari";
            btnFilterTanggal.UseVisualStyleBackColor = true;
            btnFilterTanggal.Click += btnFilterTanggal_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Penjadwalan_Menu_OFF1;
            pictureBox2.Location = new Point(16, 177);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
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
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnFilterTanggal);
            Controls.Add(dateTimePickerFilter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel_1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardAdmin";
            Text = "Dashboard Admin";
            Load += DashboardAdmin_Load;
            panel_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_1;
        private PictureBox pictureBox1;
        private PictureBox Beranda;
        private PictureBox pictureBox6;
        private DataGridView dataGridView1;
        private Label label1;
        private BindingSource bindingSource1;
        private Label label2;
        private DateTimePicker dateTimePickerFilter;
        private Button btnFilterTanggal;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}

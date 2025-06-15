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

        private Panel panelTableContainer;
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel_1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            Beranda = new PictureBox();
            pictureBox1 = new PictureBox();
            panelTableContainer = new Panel(); // panel pembungkus tabel
            dataGridView1 = new DataGridView();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            dateTimePickerFilter = new DateTimePicker();
            btnFilterTanggal = new Button();
            panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();

            // panel_1 (menu kiri)
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
            panel_1.TabIndex = 0;

            pictureBox4.Image = Properties.Resources.Penarikan_Menu_OFF;
            pictureBox4.Location = new Point(18, 388);
            pictureBox4.Size = new Size(227, 71);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox3.Image = Properties.Resources.Area_Menu_OFF;
            pictureBox3.Location = new Point(18, 312);
            pictureBox3.Size = new Size(227, 71);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox2.Image = Properties.Resources.Penjadwalan_Menu_OFF1;
            pictureBox2.Location = new Point(18, 236);
            pictureBox2.Size = new Size(227, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox6.Image = Properties.Resources.Keluar;
            pictureBox6.Location = new Point(18, 841);
            pictureBox6.Size = new Size(97, 52);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;

            Beranda.Image = Properties.Resources.Beranda_Menu;
            Beranda.Location = new Point(18, 160);
            Beranda.Size = new Size(227, 71);
            Beranda.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox1.Image = Properties.Resources.Logo_Regreen;
            pictureBox1.Location = new Point(18, 19);
            pictureBox1.Size = new Size(233, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            // panelTableContainer
            panelTableContainer = new Panel();
            panelTableContainer.Location = new Point(275, 113);
            panelTableContainer.Size = new Size(1135, 367);
            panelTableContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTableContainer.BackColor = SystemColors.Window;

            // dataGridView1
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            panelTableContainer.Controls.Add(dataGridView1);

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(275, 65);
            label1.Name = "label1";
            label1.Size = new Size(336, 31);
            label1.Text = "Jadwal Pengambilan Terdaftar";

            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(275, 523);
            label2.Name = "label2";
            label2.Size = new Size(202, 31);
            label2.Text = "Cari Pengambilan";

            // dateTimePickerFilter
            dateTimePickerFilter.Location = new Point(275, 568);
            dateTimePickerFilter.Name = "dateTimePickerFilter";
            dateTimePickerFilter.Size = new Size(263, 27);

            // btnFilterTanggal
            btnFilterTanggal.Location = new Point(275, 617);
            btnFilterTanggal.Name = "btnFilterTanggal";
            btnFilterTanggal.Size = new Size(203, 33);
            btnFilterTanggal.Text = "Cari";
            btnFilterTanggal.UseVisualStyleBackColor = true;
            btnFilterTanggal.Click += btnFilterTanggal_Click;

            // DashboardAdmin Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(panelTableContainer);
            Controls.Add(btnFilterTanggal);
            Controls.Add(dateTimePickerFilter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel_1);
            Name = "DashboardAdmin";
            Text = "Dashboard Admin";
            Load += DashboardAdmin_Load;

            panel_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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

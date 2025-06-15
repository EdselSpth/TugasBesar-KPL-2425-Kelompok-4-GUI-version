namespace View_Regreen.Menu
{
    partial class DashboardKurir
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
            panelTableContainer = new Panel();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            dateTimePickerFilter = new DateTimePicker();
            btnFilterTanggal = new Button();
            Panel_Header = new Panel();
            label_Text1 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            Panel_Header.SuspendLayout();
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
            panel_1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Penarikan_Menu_OFF;
            pictureBox4.Location = new Point(18, 388);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(227, 71);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Area_Menu_OFF;
            pictureBox3.Location = new Point(18, 312);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(227, 71);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Penjadwalan_Menu_OFF1;
            pictureBox2.Location = new Point(18, 236);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(227, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Keluar;
            pictureBox6.Location = new Point(18, 841);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(97, 52);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // Beranda
            // 
            Beranda.Image = Properties.Resources.Beranda_Menu;
            Beranda.Location = new Point(18, 160);
            Beranda.Name = "Beranda";
            Beranda.Size = new Size(227, 71);
            Beranda.SizeMode = PictureBoxSizeMode.Zoom;
            Beranda.TabIndex = 4;
            Beranda.TabStop = false;
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
            // panelTableContainer
            // 
            panelTableContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTableContainer.BackColor = SystemColors.Window;
            panelTableContainer.Controls.Add(dataGridView1);
            panelTableContainer.Location = new Point(301, 205);
            panelTableContainer.Name = "panelTableContainer";
            panelTableContainer.Size = new Size(1102, 507);
            panelTableContainer.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1102, 507);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(301, 759);
            label2.Name = "label2";
            label2.Size = new Size(202, 31);
            label2.TabIndex = 3;
            label2.Text = "Cari Pengambilan";
            // 
            // dateTimePickerFilter
            // 
            dateTimePickerFilter.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerFilter.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerFilter.Location = new Point(514, 759);
            dateTimePickerFilter.Name = "dateTimePickerFilter";
            dateTimePickerFilter.Size = new Size(382, 39);
            dateTimePickerFilter.TabIndex = 2;
            // 
            // btnFilterTanggal
            // 
            btnFilterTanggal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilterTanggal.Location = new Point(931, 759);
            btnFilterTanggal.Name = "btnFilterTanggal";
            btnFilterTanggal.Size = new Size(203, 39);
            btnFilterTanggal.TabIndex = 1;
            btnFilterTanggal.Text = "Cari";
            btnFilterTanggal.UseVisualStyleBackColor = true;
            btnFilterTanggal.Click += btnFilterTanggal_Click;
            // 
            // Panel_Header
            // 
            Panel_Header.BackColor = Color.SeaGreen;
            Panel_Header.Controls.Add(label_Text1);
            Panel_Header.Location = new Point(262, 0);
            Panel_Header.Margin = new Padding(3, 4, 3, 4);
            Panel_Header.Name = "Panel_Header";
            Panel_Header.Size = new Size(1185, 92);
            Panel_Header.TabIndex = 5;
            // 
            // label_Text1
            // 
            label_Text1.AutoSize = true;
            label_Text1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Text1.ForeColor = SystemColors.ButtonHighlight;
            label_Text1.Location = new Point(26, 23);
            label_Text1.Name = "label_Text1";
            label_Text1.Size = new Size(260, 41);
            label_Text1.TabIndex = 0;
            label_Text1.Text = "BERANDA KURIR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(301, 127);
            label1.Name = "label1";
            label1.Size = new Size(258, 41);
            label1.TabIndex = 1;
            label1.Text = "Selamat Datang, ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(514, 821);
            button1.Name = "button1";
            button1.Size = new Size(620, 44);
            button1.TabIndex = 6;
            button1.Text = "Tampilkan semua jadwal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DashboardKurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Panel_Header);
            Controls.Add(panelTableContainer);
            Controls.Add(btnFilterTanggal);
            Controls.Add(dateTimePickerFilter);
            Controls.Add(label2);
            Controls.Add(panel_1);
            Name = "DashboardKurir";
            Text = "Dashboard Kurir";
            Load += DashboardKurir_Load;
            panel_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            Panel_Header.ResumeLayout(false);
            Panel_Header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_1;
        private PictureBox pictureBox1;
        private PictureBox Beranda;
        private PictureBox pictureBox6;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private Label label2;
        private DateTimePicker dateTimePickerFilter;
        private Button btnFilterTanggal;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Panel Panel_Header;
        private Label label_Text1;
        private Label label1;
        private Button button1;
    }
}

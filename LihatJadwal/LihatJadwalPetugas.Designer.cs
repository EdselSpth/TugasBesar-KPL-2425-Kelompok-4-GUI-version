namespace LihatJadwal
{
    partial class LihatJadwalPetugas
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button buttonLoadAll;
        private Button buttonSearchByDate;
        private DateTimePicker dateTimePicker1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonLoadAll = new Button();
            buttonSearchByDate = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(20, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(744, 350);
            dataGridView1.TabIndex = 0;
            // 
            // buttonLoadAll
            // 
            buttonLoadAll.Location = new Point(20, 20);
            buttonLoadAll.Name = "buttonLoadAll";
            buttonLoadAll.Size = new Size(75, 23);
            buttonLoadAll.TabIndex = 1;
            buttonLoadAll.Text = "Load Semua Jadwal";
            buttonLoadAll.Click += buttonLoadAll_Click;
            // 
            // buttonSearchByDate
            // 
            buttonSearchByDate.Location = new Point(705, 20);
            buttonSearchByDate.Name = "buttonSearchByDate";
            buttonSearchByDate.Size = new Size(75, 27);
            buttonSearchByDate.TabIndex = 3;
            buttonSearchByDate.Text = "Cari Tanggal";
            buttonSearchByDate.Click += buttonSearchByDate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(499, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // LihatJadwalPetugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttonLoadAll);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonSearchByDate);
            Name = "LihatJadwalPetugas";
            Text = "Lihat Jadwal Petugas";
            Load += LihatJadwalPetugas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}

namespace LihatJadwal
{
    partial class Lihatjadwal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonLoadAll;
        private System.Windows.Forms.Button buttonSearchByDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            buttonLoadAll = new Button();
            buttonSearchByDate = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonLoadAll
            // 
            buttonLoadAll.Location = new Point(12, 12);
            buttonLoadAll.Name = "buttonLoadAll";
            buttonLoadAll.Size = new Size(120, 30);
            buttonLoadAll.TabIndex = 0;
            buttonLoadAll.Text = "Tampilkan";
            buttonLoadAll.UseVisualStyleBackColor = true;
            buttonLoadAll.Click += buttonLoadAll_Click;
            // 
            // buttonSearchByDate
            // 
            buttonSearchByDate.Location = new Point(632, 9);
            buttonSearchByDate.Name = "buttonSearchByDate";
            buttonSearchByDate.Size = new Size(140, 30);
            buttonSearchByDate.TabIndex = 2;
            buttonSearchByDate.Text = "Cari Jadwal";
            buttonSearchByDate.UseVisualStyleBackColor = true;
            buttonSearchByDate.Click += buttonSearchByDate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(760, 380);
            dataGridView1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(506, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(120, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(buttonLoadAll);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonSearchByDate);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Lihat Jadwal";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}

namespace tambahJadwalApp
{
    partial class formTambahJadwal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelTambahJadwal = new Label();
            LabelTanggal = new Label();
            label_jenissampah = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker = new DateTimePicker();
            comboBox_jenissampah = new ComboBox();
            textBox_namakurir = new TextBox();
            textBox_area = new TextBox();
            button_TambahJadwal = new Button();
            OutputSistem = new Label();
            SuspendLayout();
            // 
            // LabelTambahJadwal
            // 
            LabelTambahJadwal.AutoSize = true;
            LabelTambahJadwal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTambahJadwal.Location = new Point(41, 32);
            LabelTambahJadwal.Name = "LabelTambahJadwal";
            LabelTambahJadwal.Size = new Size(328, 28);
            LabelTambahJadwal.TabIndex = 0;
            LabelTambahJadwal.Text = "Tambah Jadwal Pendaftaran Sampah";
            LabelTambahJadwal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelTanggal
            // 
            LabelTanggal.AutoSize = true;
            LabelTanggal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTanggal.Location = new Point(45, 82);
            LabelTanggal.Name = "LabelTanggal";
            LabelTanggal.Size = new Size(83, 23);
            LabelTanggal.TabIndex = 1;
            LabelTanggal.Text = "Tanggal : ";
            LabelTanggal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_jenissampah
            // 
            label_jenissampah.AutoSize = true;
            label_jenissampah.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_jenissampah.Location = new Point(45, 126);
            label_jenissampah.Name = "label_jenissampah";
            label_jenissampah.Size = new Size(122, 23);
            label_jenissampah.TabIndex = 2;
            label_jenissampah.Text = "Jenis Sampah :";
            label_jenissampah.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 172);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 3;
            label2.Text = "Nama Kurir :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 213);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 4;
            label3.Text = "Area :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(174, 82);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(256, 27);
            dateTimePicker.TabIndex = 5;
            // 
            // comboBox_jenissampah
            // 
            comboBox_jenissampah.FormattingEnabled = true;
            comboBox_jenissampah.Location = new Point(173, 126);
            comboBox_jenissampah.Name = "comboBox_jenissampah";
            comboBox_jenissampah.Size = new Size(257, 28);
            comboBox_jenissampah.TabIndex = 6;
            // 
            // textBox_namakurir
            // 
            textBox_namakurir.Location = new Point(172, 168);
            textBox_namakurir.Name = "textBox_namakurir";
            textBox_namakurir.Size = new Size(258, 27);
            textBox_namakurir.TabIndex = 7;
            // 
            // textBox_area
            // 
            textBox_area.Location = new Point(171, 213);
            textBox_area.Name = "textBox_area";
            textBox_area.Size = new Size(259, 27);
            textBox_area.TabIndex = 8;
            // 
            // button_TambahJadwal
            // 
            button_TambahJadwal.Location = new Point(45, 257);
            button_TambahJadwal.Name = "button_TambahJadwal";
            button_TambahJadwal.Size = new Size(267, 33);
            button_TambahJadwal.TabIndex = 9;
            button_TambahJadwal.Text = "Tambah Jadwal";
            button_TambahJadwal.UseVisualStyleBackColor = true;
            button_TambahJadwal.Click += this.button_TambahJadwal_Click;
            // 
            // OutputSistem
            // 
            OutputSistem.AutoSize = true;
            OutputSistem.Location = new Point(45, 312);
            OutputSistem.Name = "OutputSistem";
            OutputSistem.Size = new Size(0, 20);
            OutputSistem.TabIndex = 11;
            // 
            // formTambahJadwal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputSistem);
            Controls.Add(button_TambahJadwal);
            Controls.Add(textBox_area);
            Controls.Add(textBox_namakurir);
            Controls.Add(comboBox_jenissampah);
            Controls.Add(dateTimePicker);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label_jenissampah);
            Controls.Add(LabelTanggal);
            Controls.Add(LabelTambahJadwal);
            Name = "formTambahJadwal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTambahJadwal;
        private Label LabelTanggal;
        private Label label_jenissampah;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBox_jenissampah;
        private TextBox textBox_namakurir;
        private TextBox textBox_area;
        private Button button_TambahJadwal;
        private Label OutputSistem;
    }
}

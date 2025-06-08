namespace TambahJadwal
{
    partial class Form1
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
            label1 = new Label();
            label_tanggal = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            textBoxKurir = new MaskedTextBox();
            TextBoxAreaPengambilan = new MaskedTextBox();
            button1 = new Button();
            labelInformasi = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(37, 33);
            label1.Name = "label1";
            label1.Size = new Size(366, 28);
            label1.TabIndex = 0;
            label1.Text = "Tambah Jadwal Pengambilan Sampah";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_tanggal
            // 
            label_tanggal.AutoSize = true;
            label_tanggal.Location = new Point(37, 86);
            label_tanggal.Name = "label_tanggal";
            label_tanggal.Size = new Size(68, 20);
            label_tanggal.TabIndex = 1;
            label_tanggal.Text = "Tanggal :";
            label_tanggal.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 215);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(117, 86);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 133);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 4;
            label3.Text = "Jenis Sampah :";
            label3.Click += label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(174, 133);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Organik";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(174, 163);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(73, 24);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Plastik";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(174, 193);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(72, 24);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Kertas";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(174, 223);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(77, 24);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "Logam";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(323, 133);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(96, 24);
            checkBox5.TabIndex = 9;
            checkBox5.Text = "Elektronik";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(323, 163);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(146, 24);
            checkBox6.TabIndex = 10;
            checkBox6.Text = "Bahan Berbahaya";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(323, 193);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(78, 24);
            checkBox7.TabIndex = 11;
            checkBox7.Text = "Minyak";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 267);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 12;
            label4.Text = "Nama Kurir :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 305);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 13;
            label5.Text = "Area Pengambilan :";
            // 
            // textBoxKurir
            // 
            textBoxKurir.Location = new Point(189, 263);
            textBoxKurir.Name = "textBoxKurir";
            textBoxKurir.Size = new Size(260, 27);
            textBoxKurir.TabIndex = 14;
            // 
            // TextBoxAreaPengambilan
            // 
            TextBoxAreaPengambilan.Location = new Point(189, 300);
            TextBoxAreaPengambilan.Name = "TextBoxAreaPengambilan";
            TextBoxAreaPengambilan.Size = new Size(260, 27);
            TextBoxAreaPengambilan.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(37, 355);
            button1.Name = "button1";
            button1.Size = new Size(146, 29);
            button1.TabIndex = 16;
            button1.Text = "Daftar Jadwal";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelInformasi
            // 
            labelInformasi.AutoSize = true;
            labelInformasi.Location = new Point(37, 401);
            labelInformasi.Name = "labelInformasi";
            labelInformasi.RightToLeft = RightToLeft.No;
            labelInformasi.Size = new Size(0, 20);
            labelInformasi.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelInformasi);
            Controls.Add(button1);
            Controls.Add(TextBoxAreaPengambilan);
            Controls.Add(textBoxKurir);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label_tanggal);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_tanggal;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private Label label4;
        private Label label5;
        private MaskedTextBox textBoxKurir;
        private MaskedTextBox TextBoxAreaPengambilan;
        private Button button1;
        private Label labelInformasi;
    }
}

namespace form_pendaftaran_penjemputan
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxNama = new TextBox();
            textBoxArea = new TextBox();
            textBoxTanggal = new TextBox();
            textBoxKeterangan = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 76);
            label1.Name = "label1";
            label1.Size = new Size(227, 20);
            label1.TabIndex = 0;
            label1.Text = "Pendaftaran Jadwal Penjemputan";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 107);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama Pengguna";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 155);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "Nama Area";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 204);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Waktu";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 251);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Keterangan";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(400, 104);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(208, 27);
            textBoxNama.TabIndex = 5;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(400, 155);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(208, 27);
            textBoxArea.TabIndex = 6;
            // 
            // textBoxTanggal
            // 
            textBoxTanggal.Location = new Point(400, 201);
            textBoxTanggal.Name = "textBoxTanggal";
            textBoxTanggal.Size = new Size(208, 27);
            textBoxTanggal.TabIndex = 7;
            // 
            // textBoxKeterangan
            // 
            textBoxKeterangan.Location = new Point(400, 251);
            textBoxKeterangan.Name = "textBoxKeterangan";
            textBoxKeterangan.Size = new Size(208, 27);
            textBoxKeterangan.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(310, 297);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxKeterangan);
            Controls.Add(textBoxTanggal);
            Controls.Add(textBoxArea);
            Controls.Add(textBoxNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxNama;
        private TextBox textBoxArea;
        private TextBox textBoxTanggal;
        private TextBox textBoxKeterangan;
        private Button button1;
    }
}

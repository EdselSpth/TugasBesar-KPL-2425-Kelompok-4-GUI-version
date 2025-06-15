namespace Views_Regreem
{
    partial class Regreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_text1 = new System.Windows.Forms.Label();
            this.label_Text2 = new System.Windows.Forms.Label();
            this.label_Text3 = new System.Windows.Forms.Label();
            this.inputBox_Email = new System.Windows.Forms.TextBox();
            this.InputBox_Password = new System.Windows.Forms.TextBox();
            this.label_Text4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Views_Regreem.Properties.Resources.Login_Image_1;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_text1
            // 
            this.label_text1.AutoSize = true;
            this.label_text1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_text1.Location = new System.Drawing.Point(292, 29);
            this.label_text1.Name = "label_text1";
            this.label_text1.Size = new System.Drawing.Size(90, 27);
            this.label_text1.TabIndex = 1;
            this.label_text1.Text = "MASUK";
            // 
            // label_Text2
            // 
            this.label_Text2.AutoSize = true;
            this.label_Text2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Text2.Location = new System.Drawing.Point(293, 68);
            this.label_Text2.Name = "label_Text2";
            this.label_Text2.Size = new System.Drawing.Size(365, 20);
            this.label_Text2.TabIndex = 2;
            this.label_Text2.Text = "Masuk untuk meangkses halaman utama Regreen";
            // 
            // label_Text3
            // 
            this.label_Text3.AutoSize = true;
            this.label_Text3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Text3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Text3.Location = new System.Drawing.Point(293, 124);
            this.label_Text3.Name = "label_Text3";
            this.label_Text3.Size = new System.Drawing.Size(47, 20);
            this.label_Text3.TabIndex = 3;
            this.label_Text3.Text = "Email";
            // 
            // inputBox_Email
            // 
            this.inputBox_Email.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox_Email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputBox_Email.Location = new System.Drawing.Point(297, 147);
            this.inputBox_Email.Name = "inputBox_Email";
            this.inputBox_Email.Size = new System.Drawing.Size(452, 25);
            this.inputBox_Email.TabIndex = 4;
            this.inputBox_Email.Text = "Masukkan Email Anda";
            // 
            // InputBox_Password
            // 
            this.InputBox_Password.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox_Password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.InputBox_Password.Location = new System.Drawing.Point(297, 221);
            this.InputBox_Password.Name = "InputBox_Password";
            this.InputBox_Password.Size = new System.Drawing.Size(452, 25);
            this.InputBox_Password.TabIndex = 6;
            this.InputBox_Password.Text = "Masukkan Email Anda";
            // 
            // label_Text4
            // 
            this.label_Text4.AutoSize = true;
            this.label_Text4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Text4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Text4.Location = new System.Drawing.Point(293, 198);
            this.label_Text4.Name = "label_Text4";
            this.label_Text4.Size = new System.Drawing.Size(47, 20);
            this.label_Text4.TabIndex = 5;
            this.label_Text4.Text = "Email";
            // 
            // Regreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputBox_Password);
            this.Controls.Add(this.label_Text4);
            this.Controls.Add(this.inputBox_Email);
            this.Controls.Add(this.label_Text3);
            this.Controls.Add(this.label_Text2);
            this.Controls.Add(this.label_text1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Regreen";
            this.Text = "Regreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_text1;
        private System.Windows.Forms.Label label_Text2;
        private System.Windows.Forms.Label label_Text3;
        private System.Windows.Forms.TextBox inputBox_Email;
        private System.Windows.Forms.TextBox InputBox_Password;
        private System.Windows.Forms.Label label_Text4;
    }
}


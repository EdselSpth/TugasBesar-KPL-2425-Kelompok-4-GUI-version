namespace View_Regreen
{
    partial class MenuLogin
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
            picture_1 = new PictureBox();
            label_Text1 = new Label();
            label_Text2 = new Label();
            label_Text3 = new Label();
            textBox_Username = new TextBox();
            label_Text4 = new Label();
            textBox_Password = new TextBox();
            button_Masuk = new Button();
            label1 = new Label();
            linkLabel_Register = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picture_1).BeginInit();
            SuspendLayout();
            // 
            // picture_1
            // 
            picture_1.Image = Properties.Resources.Login_Image_1;
            picture_1.Location = new Point(22, 12);
            picture_1.Name = "picture_1";
            picture_1.Size = new Size(229, 418);
            picture_1.SizeMode = PictureBoxSizeMode.Zoom;
            picture_1.TabIndex = 0;
            picture_1.TabStop = false;
            // 
            // label_Text1
            // 
            label_Text1.AutoSize = true;
            label_Text1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Text1.Location = new Point(281, 27);
            label_Text1.Name = "label_Text1";
            label_Text1.Size = new Size(74, 28);
            label_Text1.TabIndex = 1;
            label_Text1.Text = "Masuk";
            // 
            // label_Text2
            // 
            label_Text2.AutoSize = true;
            label_Text2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Text2.Location = new Point(283, 67);
            label_Text2.Name = "label_Text2";
            label_Text2.Size = new Size(392, 23);
            label_Text2.TabIndex = 2;
            label_Text2.Text = "Masuk untuk mengakses halaman utama ReGreen";
            // 
            // label_Text3
            // 
            label_Text3.AutoSize = true;
            label_Text3.Location = new Point(281, 131);
            label_Text3.Name = "label_Text3";
            label_Text3.Size = new Size(75, 20);
            label_Text3.TabIndex = 3;
            label_Text3.Text = "Username";
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(284, 158);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(485, 27);
            textBox_Username.TabIndex = 4;
            textBox_Username.Text = "Masukkan username anda";
            // 
            // label_Text4
            // 
            label_Text4.AutoSize = true;
            label_Text4.Location = new Point(281, 204);
            label_Text4.Name = "label_Text4";
            label_Text4.Size = new Size(70, 20);
            label_Text4.TabIndex = 5;
            label_Text4.Text = "Password";
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(284, 227);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(485, 27);
            textBox_Password.TabIndex = 6;
            textBox_Password.Text = "Masukkan Password Anda";
            // 
            // button_Masuk
            // 
            button_Masuk.BackColor = Color.SeaGreen;
            button_Masuk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Masuk.ForeColor = Color.Transparent;
            button_Masuk.Location = new Point(284, 275);
            button_Masuk.Name = "button_Masuk";
            button_Masuk.Size = new Size(113, 39);
            button_Masuk.TabIndex = 7;
            button_Masuk.Text = "Masuk";
            button_Masuk.UseVisualStyleBackColor = false;
            button_Masuk.Click += button_Masuk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 328);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 8;
            label1.Text = "Belum Punya Akun???";
            // 
            // linkLabel_Register
            // 
            linkLabel_Register.AutoSize = true;
            linkLabel_Register.LinkColor = Color.Green;
            linkLabel_Register.Location = new Point(442, 328);
            linkLabel_Register.Name = "linkLabel_Register";
            linkLabel_Register.Size = new Size(128, 20);
            linkLabel_Register.TabIndex = 9;
            linkLabel_Register.TabStop = true;
            linkLabel_Register.Text = "Daftar Sekarang!!!";
            linkLabel_Register.LinkClicked += linkLabel_Register_LinkClicked;
            // 
            // MenuLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel_Register);
            Controls.Add(label1);
            Controls.Add(button_Masuk);
            Controls.Add(textBox_Password);
            Controls.Add(label_Text4);
            Controls.Add(textBox_Username);
            Controls.Add(label_Text3);
            Controls.Add(label_Text2);
            Controls.Add(label_Text1);
            Controls.Add(picture_1);
            Name = "MenuLogin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picture_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picture_1;
        private Label label_Text1;
        private Label label_Text2;
        private Label label_Text3;
        private TextBox textBox_Username;
        private Label label_Text4;
        private TextBox textBox_Password;
        private Button button_Masuk;
        private Label label1;
        private LinkLabel linkLabel_Register;
    }
}

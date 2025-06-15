namespace View_Regreen.Menu
{
    partial class MenuRegister
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
            picture_1 = new PictureBox();
            textBox_Username = new TextBox();
            label_Text3 = new Label();
            label_Text2 = new Label();
            label_Text1 = new Label();
            label_Text4 = new Label();
            label_Text5 = new Label();
            comboBox1 = new ComboBox();
            button_BuatAkun = new Button();
            linkLabel_Login = new LinkLabel();
            label1 = new Label();
            textBox_Password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picture_1).BeginInit();
            SuspendLayout();
            // 
            // picture_1
            // 
            picture_1.Image = Properties.Resources.Login_Image_1;
            picture_1.Location = new Point(29, 12);
            picture_1.Name = "picture_1";
            picture_1.Size = new Size(351, 649);
            picture_1.SizeMode = PictureBoxSizeMode.Zoom;
            picture_1.TabIndex = 1;
            picture_1.TabStop = false;
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(399, 166);
            textBox_Username.Margin = new Padding(5);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(485, 27);
            textBox_Username.TabIndex = 10;
            textBox_Username.TextChanged += textBox_Username_TextChanged;
            // 
            // label_Text3
            // 
            label_Text3.AutoSize = true;
            label_Text3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Text3.Location = new Point(396, 139);
            label_Text3.Name = "label_Text3";
            label_Text3.Size = new Size(87, 23);
            label_Text3.TabIndex = 9;
            label_Text3.Text = "Username";
            // 
            // label_Text2
            // 
            label_Text2.AutoSize = true;
            label_Text2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Text2.Location = new Point(398, 75);
            label_Text2.Name = "label_Text2";
            label_Text2.Size = new Size(402, 28);
            label_Text2.TabIndex = 8;
            label_Text2.Text = "Buat akun ReGreen untuk mengakses aplikasi";
            // 
            // label_Text1
            // 
            label_Text1.AutoSize = true;
            label_Text1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Text1.Location = new Point(396, 35);
            label_Text1.Name = "label_Text1";
            label_Text1.Size = new Size(127, 31);
            label_Text1.TabIndex = 7;
            label_Text1.Text = "Buat Akun";
            // 
            // label_Text4
            // 
            label_Text4.AutoSize = true;
            label_Text4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Text4.Location = new Point(396, 207);
            label_Text4.Name = "label_Text4";
            label_Text4.Size = new Size(80, 23);
            label_Text4.TabIndex = 11;
            label_Text4.Text = "Password";
            // 
            // label_Text5
            // 
            label_Text5.AutoSize = true;
            label_Text5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Text5.Location = new Point(399, 270);
            label_Text5.Name = "label_Text5";
            label_Text5.Size = new Size(43, 23);
            label_Text5.TabIndex = 13;
            label_Text5.Text = "Role";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(401, 293);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 28);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button_BuatAkun
            // 
            button_BuatAkun.BackColor = Color.SeaGreen;
            button_BuatAkun.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_BuatAkun.ForeColor = Color.Transparent;
            button_BuatAkun.Location = new Point(399, 338);
            button_BuatAkun.Name = "button_BuatAkun";
            button_BuatAkun.Size = new Size(113, 39);
            button_BuatAkun.TabIndex = 15;
            button_BuatAkun.Text = "Buat Akun";
            button_BuatAkun.UseVisualStyleBackColor = false;
            button_BuatAkun.Click += button_BuatAkun_Click;
            // 
            // linkLabel_Login
            // 
            linkLabel_Login.AutoSize = true;
            linkLabel_Login.LinkColor = Color.Green;
            linkLabel_Login.Location = new Point(560, 391);
            linkLabel_Login.Name = "linkLabel_Login";
            linkLabel_Login.Size = new Size(46, 20);
            linkLabel_Login.TabIndex = 17;
            linkLabel_Login.TabStop = true;
            linkLabel_Login.Text = "Login";
            linkLabel_Login.LinkClicked += linkLabel_Login_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 391);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 16;
            label1.Text = "Sudah Punya Akun???";
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(399, 230);
            textBox_Password.Margin = new Padding(5);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(485, 27);
            textBox_Password.TabIndex = 12;
            textBox_Password.TextChanged += textBox_Password_TextChanged;
            // 
            // MenuRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(linkLabel_Login);
            Controls.Add(label1);
            Controls.Add(button_BuatAkun);
            Controls.Add(comboBox1);
            Controls.Add(label_Text5);
            Controls.Add(textBox_Password);
            Controls.Add(label_Text4);
            Controls.Add(textBox_Username);
            Controls.Add(label_Text3);
            Controls.Add(label_Text2);
            Controls.Add(label_Text1);
            Controls.Add(picture_1);
            Name = "MenuRegister";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picture_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picture_1;
        private TextBox textBox_Username;
        private Label label_Text3;
        private Label label_Text2;
        private Label label_Text1;
        private Label label_Text4;
        private Label label_Text5;
        private ComboBox comboBox1;
        private Button button_BuatAkun;
        private LinkLabel linkLabel_Login;
        private Label label1;
        private TextBox textBox_Password;
    }
}
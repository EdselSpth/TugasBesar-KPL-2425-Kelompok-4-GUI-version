namespace LoginApp
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
            User = new Label();
            pas = new Label();
            lbl_Reg = new Label();
            Username = new TextBox();
            Password = new TextBox();
            Register = new Button();
            Submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 63);
            label1.Name = "label1";
            label1.Size = new Size(117, 37);
            label1.TabIndex = 0;
            label1.Text = "ReGreen";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(138, 130);
            User.Name = "User";
            User.Size = new Size(60, 15);
            User.TabIndex = 1;
            User.Text = "Username";
            // 
            // pas
            // 
            pas.AutoSize = true;
            pas.Location = new Point(138, 159);
            pas.Name = "pas";
            pas.Size = new Size(53, 15);
            pas.TabIndex = 2;
            pas.Text = "Passowd";
            // 
            // lbl_Reg
            // 
            lbl_Reg.AutoSize = true;
            lbl_Reg.Location = new Point(325, 215);
            lbl_Reg.Name = "lbl_Reg";
            lbl_Reg.Size = new Size(106, 15);
            lbl_Reg.TabIndex = 3;
            lbl_Reg.Text = "Tidak punya akun?";
            // 
            // Username
            // 
            Username.Location = new Point(204, 127);
            Username.Name = "Username";
            Username.Size = new Size(332, 23);
            Username.TabIndex = 4;
            // 
            // Password
            // 
            Password.Location = new Point(204, 156);
            Password.Name = "Password";
            Password.Size = new Size(332, 23);
            Password.TabIndex = 5;
            // 
            // Register
            // 
            Register.Location = new Point(437, 211);
            Register.Name = "Register";
            Register.Size = new Size(99, 23);
            Register.TabIndex = 6;
            Register.Text = "Buat sekarang";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // Submit
            // 
            Submit.Location = new Point(342, 270);
            Submit.Name = "Submit";
            Submit.Size = new Size(72, 24);
            Submit.TabIndex = 7;
            Submit.Text = "Login";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 393);
            Controls.Add(Submit);
            Controls.Add(Register);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(lbl_Reg);
            Controls.Add(pas);
            Controls.Add(User);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label User;
        private Label pas;
        private Label lbl_Reg;
        private TextBox Username;
        private TextBox Password;
        private Button Register;
        private Button Submit;
    }
}

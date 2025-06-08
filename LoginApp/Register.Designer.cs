namespace LoginApp
{
    partial class Register
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
            App = new Label();
            UserN = new Label();
            Pass = new Label();
            Rol = new Label();
            Username = new TextBox();
            Password = new TextBox();
            Admin = new RadioButton();
            Kurir = new RadioButton();
            User = new RadioButton();
            Log = new Label();
            Login = new Button();
            Submit = new Button();
            SuspendLayout();
            // 
            // App
            // 
            App.AutoSize = true;
            App.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            App.Location = new Point(302, 47);
            App.Name = "App";
            App.Size = new Size(117, 37);
            App.TabIndex = 0;
            App.Text = "ReGreen";
            // 
            // UserN
            // 
            UserN.AutoSize = true;
            UserN.Location = new Point(85, 111);
            UserN.Name = "UserN";
            UserN.Size = new Size(60, 15);
            UserN.TabIndex = 1;
            UserN.Text = "Username";
            // 
            // Pass
            // 
            Pass.AutoSize = true;
            Pass.Location = new Point(85, 143);
            Pass.Name = "Pass";
            Pass.Size = new Size(57, 15);
            Pass.TabIndex = 2;
            Pass.Text = "Password";
            // 
            // Rol
            // 
            Rol.AutoSize = true;
            Rol.Location = new Point(85, 175);
            Rol.Name = "Rol";
            Rol.Size = new Size(30, 15);
            Rol.TabIndex = 3;
            Rol.Text = "Role";
            // 
            // Username
            // 
            Username.Location = new Point(151, 108);
            Username.Name = "Username";
            Username.Size = new Size(320, 23);
            Username.TabIndex = 4;
            Username.TextChanged += Username_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(151, 140);
            Password.Name = "Password";
            Password.Size = new Size(320, 23);
            Password.TabIndex = 5;
            Password.TextChanged += Password_TextChanged;
            // 
            // Admin
            // 
            Admin.AutoSize = true;
            Admin.Location = new Point(151, 173);
            Admin.Name = "Admin";
            Admin.Size = new Size(61, 19);
            Admin.TabIndex = 6;
            Admin.TabStop = true;
            Admin.Text = "Admin";
            Admin.UseVisualStyleBackColor = true;
            Admin.CheckedChanged += Admin_CheckedChanged;
            // 
            // Kurir
            // 
            Kurir.AutoSize = true;
            Kurir.Location = new Point(151, 198);
            Kurir.Name = "Kurir";
            Kurir.Size = new Size(50, 19);
            Kurir.TabIndex = 7;
            Kurir.TabStop = true;
            Kurir.Text = "Kurir";
            Kurir.UseVisualStyleBackColor = true;
            Kurir.CheckedChanged += Kurir_CheckedChanged;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(151, 223);
            User.Name = "User";
            User.Size = new Size(48, 19);
            User.TabIndex = 8;
            User.TabStop = true;
            User.Text = "User";
            User.UseVisualStyleBackColor = true;
            User.CheckedChanged += User_CheckedChanged;
            // 
            // Log
            // 
            Log.AutoSize = true;
            Log.Location = new Point(379, 264);
            Log.Name = "Log";
            Log.Size = new Size(110, 15);
            Log.TabIndex = 9;
            Log.Text = "Sudah punya akun?";
            // 
            // Login
            // 
            Login.Location = new Point(495, 260);
            Login.Name = "Login";
            Login.Size = new Size(75, 23);
            Login.TabIndex = 10;
            Login.Text = "Login sekarang";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Submit
            // 
            Submit.Location = new Point(266, 311);
            Submit.Name = "Submit";
            Submit.Size = new Size(86, 23);
            Submit.TabIndex = 11;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 385);
            Controls.Add(Submit);
            Controls.Add(Login);
            Controls.Add(Log);
            Controls.Add(User);
            Controls.Add(Kurir);
            Controls.Add(Admin);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(Rol);
            Controls.Add(Pass);
            Controls.Add(UserN);
            Controls.Add(App);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label App;
        private Label UserN;
        private Label Pass;
        private Label Rol;
        private TextBox Username;
        private TextBox Password;
        private RadioButton Admin;
        private RadioButton Kurir;
        private RadioButton User;
        private Label Log;
        private Button Login;
        private Button Submit;
    }
}
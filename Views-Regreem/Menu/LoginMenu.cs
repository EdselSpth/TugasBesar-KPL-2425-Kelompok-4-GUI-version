using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Http;


namespace Views_Regreem
{
    public partial class Regreen: Form
    {
        public Regreen()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
        }

        private void button_ToRegister_Click(object sender, EventArgs e)
        {
        }

        private async void button_Login_Click(object sender, EventArgs e)
        {
            var username = inputBox_Email.Text.Trim();
            var password = InputBox_Password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan Password tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = new
            {
                Username = username,
                Password = password
            };

            try
            {
                string apiUrl = "http://localhost:5296/api/Auth/login";
                var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(apiUrl, content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var json = JsonDocument.Parse(responseBody);
                    string usernameLogin = json.RootElement.GetProperty("username").GetString();
                    int roleNumber = json.RootElement.GetProperty("role").GetInt32();

                    Role roleEnum = (Role)roleNumber;
                    Console.WriteLine($"Role Enum: {roleEnum}"); // Debugging line to check role enum value

                    string role = roleEnum.ToString().ToLower();

                    MessageBox.Show($"Login successful as {username} (Role: {role})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    switch (role)
                    {
                        case "admin":
                            // Navigate to Admin form
                            var adminForm = new adminAPP.Form1();
                            adminForm.Show();
                            this.Hide();
                            break;
                        case "kurir":
                            // Navigate to Kurir form
                            // KurirForm kurirForm = new KurirForm();
                            // kurirForm.Show();
                            // this.Hide();
                            break;
                        case "user":
                            // Navigate to User form
                            // UserForm userForm = new UserForm();
                            // userForm.Show();
                            // this.Hide();
                            break;
                        default:
                            MessageBox.Show("Role not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    var json = JsonDocument.Parse(responseBody);
                    string errorMessage = json.RootElement.GetProperty("message").GetString();
                    MessageBox.Show($"Login failed: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) // Renamed the variable from 'e' to 'ex' to avoid conflict
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

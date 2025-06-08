using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading;
using LoginAPI.Models;


namespace LoginApp
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            var regForm = new Register();
            regForm.Show();
            this.Hide();
        }

        private async void Submit_Click(object sender, EventArgs e)
        {
            var username = Username.Text.Trim();
            var password = Password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    string role = roleEnum.ToString().ToLower();

                    MessageBox.Show($"Login successful as {username} (Role: {role})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    switch (role)
                    {
                        case "admin":
                            // Navigate to Admin form
                            // AdminForm adminForm = new AdminForm();
                            // adminForm.Show();
                            // this.Hide();
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

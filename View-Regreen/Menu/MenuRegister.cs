using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using LoginAPI.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace View_Regreen.Menu
{
    public partial class MenuRegister : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public MenuRegister()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");

            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Kurir");
            comboBox1.Items.Add("User");
            comboBox1.SelectedIndex = 2; // Default to User
        }

        private Role? GetSelectedRole()
        {
            if (comboBox1.SelectedItem == null)
                return null;
            string selectedRole = comboBox1.SelectedItem.ToString();
            return selectedRole switch
            {
                "Admin" => Role.Admin,
                "Kurir" => Role.Kurir,
                "User" => Role.User,
                _ => null
            };
        }

        private async void button_BuatAkun_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text.Trim();
            string password = textBox_Password.Text;
            Role? selectedRole = GetSelectedRole();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || selectedRole == null)
            {
                MessageBox.Show("Isi semua field dan pilih role.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Role role = selectedRole.Value;

            var userData = new
            {
                Username = username,
                Password = password,
                Role = role
            };

            try
            {
                string apiUrl = "http://localhost:5296/api/Auth/register";
                string json = JsonSerializer.Serialize(userData);

                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(apiUrl, content);
                string responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Registrasi berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var loginForm = new MenuLogin();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    string errorMessage = "Registrasi gagal.";
                    try
                    {
                        var jsonDoc = JsonDocument.Parse(responseBody);
                        if (jsonDoc.RootElement.TryGetProperty("message", out var msg))
                        {
                            errorMessage = msg.GetString();
                        }
                    }
                    catch { }

                    MessageBox.Show($"Registrasi gagal: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new MenuLogin();
            loginForm.Show();
            this.Hide();
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

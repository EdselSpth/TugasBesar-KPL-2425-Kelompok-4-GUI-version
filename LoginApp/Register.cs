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

namespace LoginApp
{
    public partial class Register : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public Register()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_CheckedChanged(object sender, EventArgs e)
        {
            if (Admin.Checked)
            {
                Kurir.Checked = false;
                User.Checked = false;
            }
        }

        private void Kurir_CheckedChanged(object sender, EventArgs e)
        {
            if (Kurir.Checked)
            {
                Admin.Checked = false;
                User.Checked = false;
            }
        }

        private void User_CheckedChanged(object sender, EventArgs e)
        {
            if (User.Checked)
            {
                Admin.Checked = false;
                Kurir.Checked = false;
            }
        }

        private Role? GetSelectedRole()
        {
            if (Admin.Checked) return Role.Admin;
            if (Kurir.Checked) return Role.Kurir;
            if (User.Checked) return Role.User;
            return null;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private async void Submit_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim();
            string password = Password.Text;
            Role? selectedRole = GetSelectedRole();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || selectedRole == null)
            {
                MessageBox.Show("Isi semua field dan pilih role.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Role role = selectedRole.Value;

            var userData = new User
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
                    var loginForm = new Form1();
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
    }
}

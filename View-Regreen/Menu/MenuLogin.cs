using LoginAPI.Models;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using LoginAPI;
using View_Regreen.Admin;
using System.Windows.Forms;
using System.Drawing;
using View_Regreen.Menu;

namespace View_Regreen
{
    public partial class MenuLogin : Form
    {
        private readonly HttpClient _httpClient = new();

        public MenuLogin()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var regForm = new MenuRegister();
            regForm.Show();
            this.Hide();
        }

        private async void button_Masuk_Click(object sender, EventArgs e)
        {
            var username = textBox_Username.Text.Trim();
            var password = textBox_Password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var json = JsonDocument.Parse(responseBody);

                if (response.IsSuccessStatusCode)
                {
                    if (!json.RootElement.TryGetProperty("username", out var usernameElement) ||
                        !json.RootElement.TryGetProperty("role", out var roleElement))
                    {
                        MessageBox.Show("Data login tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string usernameLogin = usernameElement.GetString();
                    int roleNumber = roleElement.GetInt32();

                    if (!Enum.IsDefined(typeof(Role), roleNumber))
                    {
                        MessageBox.Show("Role tidak dikenal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Role roleEnum = (Role)roleNumber;
                    string role = roleEnum.ToString().ToLower();

                    MessageBox.Show($"Login berhasil sebagai {usernameLogin} (Role: {role})", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Session.Username = usernameLogin;
                    Session.Role = role;

                    switch (role)
                    {
                        case "admin":
                            var dashboardAdmin = new DashboardAdmin();
                            dashboardAdmin.Show();
                            this.Hide();
                            break;

                        case "kurir":
                            // TODO: Panggil form kurir
                            break;

                        case "user":
                            // TODO: Panggil form user
                            break;

                        default:
                            MessageBox.Show("Role tidak dikenali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    if (json.RootElement.TryGetProperty("message", out var msg))
                    {
                        string errorMessage = msg.GetString();
                        MessageBox.Show($"Login gagal: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Login gagal dengan kesalahan yang tidak diketahui.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuLogin_Load(object sender, EventArgs e)
        {
            // Optional: tindakan saat form dimuat
        }
    }
}

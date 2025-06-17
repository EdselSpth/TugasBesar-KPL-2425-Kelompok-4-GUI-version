using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TugasBesar_KPL_2425_Kelompok_4.Penarikan_Keuntungan.StateBasedPenarikan;
using TugasBesar_KPL_2425_Kelompok_4.Penarikan_Keuntungan;
using View_Regreen.Admin;
using View_Regreen.Menu;

namespace View_Regreen.User
{
    public partial class MenuPenarikanKeuntungan : Form
    {
        private string nominal;
        private string rekening;
        private string metodePembayaran;

        public MenuPenarikanKeuntungan()
        {
            InitializeComponent();
            Load += MenuPenarikanKeuntungan_Load;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox2.TextChanged += textBox2_TextChanged;
        }

        private void MenuPenarikanKeuntungan_Load(object sender, EventArgs e)
        {
            // Atur warna latar belakang form
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");

            button1.Text = "Tarik";
            this.Text = "Form Penarikan Customer";

            // Styling TextBox Nominal
            textBox1.BackColor = ColorTranslator.FromHtml("#DFE4D5");
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Multiline = true;
            textBox1.Height = 25;
            textBox1.TextAlign = HorizontalAlignment.Left;
            textBox1.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            // Styling TextBox Rekening
            textBox2.BackColor = ColorTranslator.FromHtml("#DFE4D5");
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Multiline = true;
            textBox2.Height = 25;
            textBox2.TextAlign = HorizontalAlignment.Left;
            textBox2.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            // Styling tombol kirim
            button1.Text = "Tarik";
            button1.BackColor = ColorTranslator.FromHtml("#558B3E");
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#6FAF50");
            button1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button1.TextAlign = ContentAlignment.MiddleCenter;

            // Inisialisasi metode pembayara// Inisialisasi metode pembayara
            string[] metode = { "BCA", "BNI", "Mandiri", "BRI", "ShopeePay", "Gopay", "Dana", "Tunai" };
            Button[] buttons = { button2, button3, button4, button5, button6, button7, button8, button9 };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = metode[i];
                buttons[i].Click += MetodeButton_Click;
            }

            // Panel styling warna putih
            Color putih = ColorTranslator.FromHtml("#FFFFFF");
            foreach (var panel in new[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8 })
            {
                panel.BackColor = putih;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nominal = textBox1.Text;
            UpdateTotalDiterimaLabel(); // Update label setiap nominal berubah
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Hanya izinkan angka, maksimal 12 digit
            string input = textBox2.Text;
            string angkaSaja = new string(input.Where(char.IsDigit).ToArray());

            if (angkaSaja.Length > 12)
                angkaSaja = angkaSaja.Substring(0, 12);

            textBox2.Text = angkaSaja;
            textBox2.SelectionStart = angkaSaja.Length;
            rekening = angkaSaja;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Validasi input wajib diisi
            if (string.IsNullOrWhiteSpace(nominal) || string.IsNullOrWhiteSpace(rekening) || string.IsNullOrWhiteSpace(metodePembayaran))
            {
                MessageBox.Show("Harap lengkapi semua data penarikan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi format nominal
            if (!decimal.TryParse(nominal, out decimal nominalDecimal) || nominalDecimal <= 0)
            {
                MessageBox.Show("Nominal tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi enum metode pembayaran
            if (!Enum.TryParse(metodePembayaran, true, out Pembayaran metode))
            {
                MessageBox.Show("Metode pembayaran tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Ambil info pembayaran dari tabel
                var info = PenarikanCustomer.PembayaranTable[metode];

                // Validasi minimal penarikan
                if (nominalDecimal < info.MinimalPenarikan)
                {
                    MessageBox.Show($"Minimal penarikan untuk metode ini adalah {info.MinimalPenarikan}.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hitung total diterima
                decimal totalDiterima = nominalDecimal - info.BiayaAdmin;

                // Tambahkan ke riwayat
                PenarikanCustomer.RiwayatPenarikan.Add(new PenarikanData(rekening, nominalDecimal, metode));

                // Simulasi proses penarikan
                PenarikanState currentState = PenarikanState.MEMASUKKAN_DATA;
                currentState = StateBasedPenarikan.GetNextState(currentState, PenarikanTrigger.SUBMIT);

                MessageBox.Show("Memproses penarikan, mohon tunggu...", "Proses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await Task.Delay(2000); // delay simulasi proses

                currentState = PenarikanState.BERHASIL;
                MessageBox.Show(
                    $"Penarikan berhasil!\n" +
                    $"Nomor Rekening: {rekening}\n" +
                    $"Metode Pembayaran: {metodePembayaran}\n" +
                    $"Total diterima setelah admin ({info.BiayaAdmin}): {totalDiterima}\n" +
                    $"Status: {currentState}",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Terjadi kesalahan: metode pembayaran tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan tak terduga:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalDiterimaLabel()
        {
            // Tampilkan estimasi total diterima
            if (decimal.TryParse(nominal, out decimal nominalDecimal) &&
                Enum.TryParse(metodePembayaran, true, out Pembayaran metode) &&
                PenarikanCustomer.PembayaranTable.TryGetValue(metode, out var info))
            {
                decimal totalDiterima = nominalDecimal - info.BiayaAdmin;

                // Pastikan tidak tampil negatif
                if (totalDiterima >= 0)
                    label5.Text = $"Total Diterima: {totalDiterima}";
                else
                    label5.Text = $"Total Diterima: 0";
            }
            else
            {
                label5.Text = "Total Diterima: -";
            }
        }

        private void MetodeButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            metodePembayaran = btn.Text; // ambil teks dari tombol sebagai metode

            // Highlight tombol aktif
            ResetButtonStyles();
            btn.BackColor = ColorTranslator.FromHtml("#3B7C87"); // biru
            btn.ForeColor = Color.White;

            // Update estimasi
            UpdateTotalDiterimaLabel();
        }

        private void ResetButtonStyles()
        {
            // Reset warna semua tombol metode
            foreach (var b in new[] { button2, button3, button4, button5, button6, button7, button8, button9 })
            {
                b.BackColor = SystemColors.Control;
                b.ForeColor = Color.White;
                b.BackColor = ColorTranslator.FromHtml("#558B3E");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MetodeButton_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MetodeButton_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MetodeButton_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MetodeButton_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MetodeButton_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MetodeButton_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MetodeButton_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MetodeButton_Click(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Beranda_Click(object sender, EventArgs e)
        {
            var dashboardUser = new DashboardUser();
            dashboardUser.Show();
            this.Hide(); // Sembunyikan form saat ini
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var menuDaftarPengambilan = new MenuDaftarPengambilan();
            menuDaftarPengambilan.Show();
            this.Hide(); // Sembunyikan form saat ini
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var menuDaftarArea = new MenuDaftarArea();
            menuDaftarArea.Show();
            this.Hide(); // Sembunyikan form saat ini
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin meh metu?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Session.Username = null; // Hapus username dari session
                Session.Role = null; // Hapus role dari session

                // Kembali ke menu login
                var menuLogin = new MenuLogin();
                menuLogin.Show();

                this.Close(); // Sembunyikan form saat ini
            }
        }
    }
}
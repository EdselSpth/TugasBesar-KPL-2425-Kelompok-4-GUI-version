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
            this.BackColor = ColorTranslator.FromHtml("#E8EDDE");

            button1.Text = "Kirim";
            this.Text = "Form Penarikan Customer";

            textBox1.BackColor = ColorTranslator.FromHtml("#DFE4D5");
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Multiline = true;
            textBox1.Height = 25;
            textBox1.TextAlign = HorizontalAlignment.Left;
            textBox1.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            textBox2.BackColor = ColorTranslator.FromHtml("#DFE4D5");
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Multiline = true;
            textBox2.Height = 25;
            textBox2.TextAlign = HorizontalAlignment.Left;
            textBox2.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            button1.Text = "Kirim";
            button1.BackColor = ColorTranslator.FromHtml("#558B3E");
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#6FAF50");
            button1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button1.TextAlign = ContentAlignment.MiddleCenter;

            button2.Text = "BCA";
            button3.Text = "BNI";
            button4.Text = "Mandiri";
            button5.Text = "BRI";
            button6.Text = "ShopeePay";
            button7.Text = "Gopay";
            button8.Text = "Dana";
            button9.Text = "Tunai";

            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button8_Click;
            button9.Click += button9_Click;

            Color putih = ColorTranslator.FromHtml("#FFFFFF");

            panel1.BackColor = putih;
            panel2.BackColor = putih;
            panel3.BackColor = putih;
            panel4.BackColor = putih;
            panel5.BackColor = putih;
            panel6.BackColor = putih;
            panel7.BackColor = putih;
            panel8.BackColor = putih;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nominal = textBox1.Text;
            UpdateTotalDiterimaLabel();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
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
            if (string.IsNullOrWhiteSpace(nominal) || string.IsNullOrWhiteSpace(rekening) || string.IsNullOrWhiteSpace(metodePembayaran))
            {
                MessageBox.Show("Harap lengkapi semua data penarikan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(nominal, out decimal nominalDecimal))
            {
                MessageBox.Show("Nominal tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Enum.TryParse(metodePembayaran, true, out Pembayaran metode))
            {
                MessageBox.Show("Metode pembayaran tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var info = PenarikanCustomer.PembayaranTable[metode];

            if (nominalDecimal < info.MinimalPenarikan)
            {
                MessageBox.Show($"Minimal penarikan untuk metode ini adalah {info.MinimalPenarikan}.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalDiterima = nominalDecimal - info.BiayaAdmin;

            PenarikanCustomer.RiwayatPenarikan.Add(new PenarikanData(rekening, nominalDecimal, metode));

            PenarikanState currentState = PenarikanState.MEMASUKKAN_DATA;
            currentState = StateBasedPenarikan.GetNextState(currentState, PenarikanTrigger.SUBMIT);

            MessageBox.Show("Memproses penarikan, mohon tunggu...", "Proses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await System.Threading.Tasks.Task.Delay(2000);
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

        private void UpdateTotalDiterimaLabel()
        {
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

            // Optional: Highlight tombol yang dipilih
            ResetButtonStyles();
            btn.BackColor = ColorTranslator.FromHtml("#3B7C87"); // biru
            btn.ForeColor = Color.White;

            // Update label total diterima
            UpdateTotalDiterimaLabel();
        }

        private void ResetButtonStyles()
        {
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
            var result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

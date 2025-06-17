using modelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule;
using View_Regreen.Menu;

namespace View_Regreen.User
{
    public partial class MenuDaftarPengambilan : Form
    {
        private List<configPendaftaraanArea> daftarArea = new();

        // Konstruktor form MenuDaftarPengambilan
        public MenuDaftarPengambilan()
        {
            InitializeComponent();
            Load += MenuDaftarPengambilan_Load;
        }

        // Method ini dijalankan saat form pertama kali dimuat
        private void MenuDaftarPengambilan_Load(object sender, EventArgs e)
        {
            LoadArea();
            UpdateJenisSampahValid();
        }

        // Method untuk memuat daftar area dari file JSON ke comboBox
        private void LoadArea()
        {
            // Menangani error saat memuat daftar area dari file JSON
            try
            {
                var areaService = new configPendaftaraanArea();
                daftarArea = areaService.GetAllArea();

                comboBoxArea.Items.Clear();

                foreach (var area in daftarArea)
                {
                    // Validasi: Hanya tambahkan area jika tidak kosong/null
                    if (!string.IsNullOrWhiteSpace(area.area))
                    {
                        comboBoxArea.Items.Add(area.area);
                    }
                }

                // Jika ada area yang berhasil dimuat, pilih item pertama
                if (comboBoxArea.Items.Count > 0)
                {
                    comboBoxArea.SelectedIndex = 0;
                }
            }
            // Menangani error saat gagal load area
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat area: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method yang dipanggil saat user mengubah tanggal
        private void DateTimePickerTanggal_ValueChanged(object sender, EventArgs e)
        {
            UpdateJenisSampahValid();
        }

        // Method untuk memperbarui daftar jenis sampah valid berdasarkan tanggal
        private void UpdateJenisSampahValid()
        {
            var tanggal = dateTimePickerTanggal.Value.Date;

            var jenisValid = Enum.GetValues(typeof(JenisSampah))
                                 .Cast<JenisSampah>()
                                 .Where(jenis => RulesJadwal.pengambilanValidasi(jenis, tanggal))
                                 .ToList();

            listBoxJenisSampah.Items.Clear();

            // Jika tidak ada jenis sampah valid pada tanggal tersebut
            if (!jenisValid.Any())
            {
                listBoxJenisSampah.Items.Add("Tidak ada jadwal pengambilan.");
            }
            // Jika ada jenis sampah valid, tampilkan di ListBox
            else
            {
                foreach (var jenis in jenisValid)
                {
                    listBoxJenisSampah.Items.Add(jenis.ToString());
                }
            }
        }

        // Method yang dipanggil saat tombol "Daftar" diklik
        private void BtnDaftar_Click(object sender, EventArgs e)
        {
            string nama = txtNamaPengguna.Text.Trim();
            string keterangan = txtKeterangan.Text.Trim();
            DateTime tanggal = dateTimePickerTanggal.Value.Date;

            // Validasi input nama: pengguna harus mengisi nama sebelum mendaftar
            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama pengguna tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi: Area harus dipilih dari comboBox
            if (comboBoxArea.SelectedIndex < 0 || comboBoxArea.SelectedIndex >= daftarArea.Count)
            {
                MessageBox.Show("Silakan pilih area terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var jenisValid = Enum.GetValues(typeof(JenisSampah))
                                 .Cast<JenisSampah>()
                                 .Where(jenis => RulesJadwal.pengambilanValidasi(jenis, tanggal))
                                 .ToList();

            // Validasi: Tidak boleh daftar jika tidak ada jenis sampah valid
            if (!jenisValid.Any())
            {
                MessageBox.Show("Tidak ada sampah yang dijadwalkan pada hari tersebut.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validasi: Keterangan tidak boleh kosong
            if (string.IsNullOrWhiteSpace(keterangan))
            {
                MessageBox.Show("Keterangan tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var areaTerpilih = daftarArea[comboBoxArea.SelectedIndex];

            var pendaftaran = new configPendaftaranPenjemputan<string>
            {
                namaPengguna = nama,
                Area = areaTerpilih,
                Jadwal = tanggal,
                Keterangan = keterangan
            };

            // Menangani proses penyimpanan data ke file JSON
            try
            {
                pendaftaran.Simpan();
                MessageBox.Show("Pendaftaran berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            // Menangani error saat penyimpanan gagal
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method untuk mereset semua field input ke nilai awal
        private void ResetForm()
        {
            txtNamaPengguna.Clear();
            txtKeterangan.Clear();
            dateTimePickerTanggal.Value = DateTime.Today;

            // Reset pilihan area ke item pertama jika ada
            comboBoxArea.SelectedIndex = comboBoxArea.Items.Count > 0 ? 0 : -1;

            UpdateJenisSampahValid();
        }

        // Method navigasi ke halaman beranda pengguna
        private void Beranda_Click(object sender, EventArgs e)
        {
            Navigasi(new DashboardUser());
        }

        // Method navigasi ke menu penarikan keuntungan
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Navigasi(new MenuPenarikanKeuntungan());
        }

        // Method navigasi ke menu daftar area
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Navigasi(new MenuDaftarArea());
        }

        // Method untuk keluar dan kembali ke login
        private void PictureBox6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Jika user memilih Yes, lakukan logout
            if (result == DialogResult.Yes)
            {
                Session.Username = null;
                Session.Role = null;

                var menuLogin = new MenuLogin();
                menuLogin.Show();

                this.Close();
            }
        }

        // Method untuk navigasi ke form lain
        private void Navigasi(Form target)
        {
            target.Show();
            Hide();
        }
    }
}


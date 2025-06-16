using modelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule;
using View_Regreen.Menu;

namespace View_Regreen.User
{
    public partial class MenuDaftarPengambilan : Form
    {
        private List<configPendaftaraanArea> daftarArea = new();

        public MenuDaftarPengambilan()
        {
            InitializeComponent();
            Load += MenuDaftarPengambilan_Load;
        }

        private void MenuDaftarPengambilan_Load(object sender, EventArgs e)
        {
            LoadArea();
            UpdateJenisSampahValid();

        }

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

                    // Hanya tambahkan area yang valid (tidak kosong/null)
                    if (!string.IsNullOrWhiteSpace(area.area))
                        comboBoxArea.Items.Add(area.area);
                }

                // Jika ada area, pilih item pertama
                if (comboBoxArea.Items.Count > 0)
                    comboBoxArea.SelectedIndex = 0;
            }
            catch (Exception ex) // Tampilkan pesan error jika gagal load area
            {
                MessageBox.Show($"Gagal memuat area: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerTanggal_ValueChanged(object sender, EventArgs e)
        {
            UpdateJenisSampahValid();
        }

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

            // Tampilkan semua jenis sampah yang valid
            else
            {
                foreach (var jenis in jenisValid)
                {
                    listBoxJenisSampah.Items.Add(jenis.ToString());
                }
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string nama = txtNamaPengguna.Text.Trim();
            string keterangan = txtKeterangan.Text.Trim();
            DateTime tanggal = dateTimePickerTanggal.Value.Date;

            // Validasi: Nama pengguna tidak boleh kosong
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

            // Validasi: Tidak boleh daftar jika tidak ada jenis sampah valid pada tanggal tsb
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

            try // Proses penyimpanan data ke file JSON
            {
                pendaftaran.Simpan();
                MessageBox.Show("Pendaftaran berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex) // Menangani error saat menyimpan
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            txtNamaPengguna.Clear();
            txtKeterangan.Clear();
            dateTimePickerTanggal.Value = DateTime.Today;

            // Reset pilihan area ke item pertama jika ada
            comboBoxArea.SelectedIndex = comboBoxArea.Items.Count > 0 ? 0 : -1;
            UpdateJenisSampahValid();
        }

        private void Beranda_Click(object sender, EventArgs e) => Navigasi(new DashboardUser());

        private void pictureBox3_Click(object sender, EventArgs e) => Navigasi(new MenuPenarikanKeuntungan());

        private void pictureBox4_Click(object sender, EventArgs e) => Navigasi(new MenuDaftarArea());

        private void pictureBox6_Click(object sender, EventArgs e)
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

        private void Navigasi(Form target)
        {
            target.Show();
            Hide(); 
        }
    }
}

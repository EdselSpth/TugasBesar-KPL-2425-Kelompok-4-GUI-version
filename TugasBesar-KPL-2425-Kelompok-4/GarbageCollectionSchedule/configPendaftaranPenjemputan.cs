using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using modelLibrary;
using JadwalAPI;

namespace TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule
{
    public class ConfigPendaftaranPenjemputan<T>
    {
        private readonly string configPath = "Riwayat_Pendaftaran_Penjemputan.json";

        public int Id { get; set; }
        public string NamaPengguna { get; set; }
        public ConfigPendaftaranArea Area { get; set; }
        public DateTime Jadwal { get; set; }
        public T Keterangan { get; set; }

        // Constructor default
        public ConfigPendaftaranPenjemputan() { }

        // Constructor dengan path custom
        public ConfigPendaftaranPenjemputan(string path)
        {
            configPath = path;
        }

        // Menyimpan pendaftaran penjemputan ke file JSON
        public void Simpan()
        {
            List<ConfigPendaftaranPenjemputan<T>> data = new();

            try
            {
                // Cek apakah file sudah ada
                if (File.Exists(configPath))
                {
                    string content = File.ReadAllText(configPath);

                    // Validasi isi file tidak kosong
                    if (!string.IsNullOrWhiteSpace(content))
                    {
                        data = JsonSerializer.Deserialize<List<ConfigPendaftaranPenjemputan<T>>>(content)
                               ?? new List<ConfigPendaftaranPenjemputan<T>>();
                    }
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Gagal membaca file JSON:");
                Console.WriteLine($"Detail: {ex.Message}");
                return;
            }

            // Tentukan ID baru berdasarkan ID tertinggi yang ada
            int maxId = data.Any() ? data.Max(d => d.Id) : 0;
            this.Id = maxId + 1;

            data.Add(this);

            try
            {
                string serialized = JsonSerializer.Serialize(data, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(configPath, serialized);
                Console.WriteLine("Pendaftaran berhasil disimpan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal menyimpan data ke file.");
                Console.WriteLine($"Detail: {ex.Message}");
            }
        }

        // Mengambil semua data dari file JSON
        public List<ConfigPendaftaranPenjemputan<T>> AmbilSemua()
        {
            try
            {
                if (!File.Exists(configPath)) return new();

                string content = File.ReadAllText(configPath);
                if (string.IsNullOrWhiteSpace(content)) return new();

                return JsonSerializer.Deserialize<List<ConfigPendaftaranPenjemputan<T>>>(content)
                       ?? new List<ConfigPendaftaranPenjemputan<T>>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal mengambil data:");
                Console.WriteLine($"Detail: {ex.Message}");
                return new List<ConfigPendaftaranPenjemputan<T>>();
            }
        }

        // Mendaftarkan pengguna melalui input console
        public static void DaftarkanPengambilanSampah(string username)
        {
            ConfigPendaftaranArea areaConfig = new();
            List<ConfigPendaftaranArea> semuaArea = areaConfig.GetAllArea();

            // Validasi jika tidak ada area
            if (semuaArea.Count == 0)
            {
                Console.WriteLine("Belum ada area yang tersedia. Silakan daftarkan area terlebih dahulu.");
                return;
            }

            Console.WriteLine("Area pengambilan sampah:");
            for (int i = 0; i < semuaArea.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {semuaArea[i].Area}");
            }

            Console.Write("Masukkan nomor area: ");
            string input = Console.ReadLine();

            // Validasi input angka
            if (!int.TryParse(input, out int nomorArea))
            {
                Console.WriteLine("Input bukan angka.");
                return;
            }

            // Validasi rentang nomor area
            if (nomorArea < 1 || nomorArea > semuaArea.Count)
            {
                Console.WriteLine("Pilihan tidak valid.");
                return;
            }

            ConfigPendaftaranArea areaTerpilih = semuaArea[nomorArea - 1];

            Console.Write("Masukkan tanggal penjemputan (format: yyyy-MM-dd): ");
            string inputTanggal = Console.ReadLine();

            // Validasi input tanggal
            if (!DateTime.TryParse(inputTanggal, out DateTime tanggalJemput))
            {
                Console.WriteLine("Tanggal tidak valid.");
                return;
            }

            DateOnly tgl = DateOnly.FromDateTime(tanggalJemput);
            DayOfWeek hari = tgl.DayOfWeek;

            // Ambil jenis sampah yang valid berdasarkan hari
            var jenisYangValid = Enum.GetValues(typeof(JenisSampah))
                                     .Cast<JenisSampah>()
                                     .Where(js => RulesJadwal.pengambilanValidasi(js, tanggalJemput))
                                     .ToList();

            // Validasi jika tidak ada jenis sampah yang bisa disetorkan
            if (jenisYangValid.Count == 0)
            {
                Console.WriteLine("Tidak ada sampah yang dijadwalkan pada hari tersebut.");
                return;
            }

            Console.WriteLine("Sampah yang dapat disetorkan:");
            foreach (var jenis in jenisYangValid)
            {
                Console.WriteLine(jenis.ToString().ToLower());
            }

            Console.Write("Masukkan keterangan jumlah sampah: ");
            string keterangan = Console.ReadLine();

            // Validasi input keterangan
            if (string.IsNullOrWhiteSpace(keterangan))
            {
                Console.WriteLine("Keterangan tidak boleh kosong.");
                return;
            }

            var pendaftaran = new ConfigPendaftaranPenjemputan<string>
            {
                NamaPengguna = username,
                Area = areaTerpilih,
                Jadwal = tanggalJemput,
                Keterangan = keterangan
            };

            pendaftaran.Simpan();
        }
    }
}

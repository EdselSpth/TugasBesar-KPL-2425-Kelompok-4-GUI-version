using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule
{
    public class ConfigPendaftaranArea
    {
        private readonly string _configPath;

        // Properti ID dan Area
        public int Id { get; set; }
        public string Area { get; set; }

        // Konstruktor default: menggunakan path default file JSON
        public ConfigPendaftaranArea()
        {
            _configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "daftarAreaFix.json");
        }

        // Konstruktor custom: untuk menentukan path file JSON sendiri
        public ConfigPendaftaranArea(string customPath)
        {
            _configPath = customPath;
        }

        // Mengambil semua data area dari file JSON
        public List<ConfigPendaftaranArea> GetAllArea()
        {
            List<ConfigPendaftaranArea> listArea = new();

            try
            {
                // Cek apakah file JSON ada
                if (File.Exists(_configPath))
                {
                    string jsonContent = File.ReadAllText(_configPath);

                    // Cek jika isi file tidak kosong
                    if (!string.IsNullOrWhiteSpace(jsonContent))
                    {
                        listArea = JsonSerializer.Deserialize<List<ConfigPendaftaranArea>>(jsonContent)
                                   ?? new List<ConfigPendaftaranArea>();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal membaca file JSON:");
                Console.WriteLine($"Detail: {ex.Message}");
            }

            return listArea;
        }

        // Menyimpan data area baru ke file JSON
        public void SaveArea()
        {
            try
            {
                // Validasi nama area tidak boleh kosong/null
                if (string.IsNullOrWhiteSpace(this.Area))
                {
                    Console.WriteLine("Nama area tidak valid.");
                    return;
                }

                var listArea = GetAllArea();

                // Cek apakah area sudah ada (case-insensitive)
                if (listArea.Any(a => a.Area != null &&
                                      a.Area.Equals(this.Area, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Area sudah ada. Tidak disimpan ulang.");
                    return;
                }

                // Tambahkan ID baru secara increment
                int maxId = listArea.Any() ? listArea.Max(a => a.Id) : 0;
                this.Id = maxId + 1;

                listArea.Add(this);

                // Serialisasi dan simpan kembali ke file JSON
                string newData = JsonSerializer.Serialize(listArea, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_configPath, newData);

                Console.WriteLine("Data Area berhasil disimpan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat menyimpan data area.");
                Console.WriteLine($"Detail: {ex.Message}");
            }
        }

        // Menampilkan semua area dari file JSON ke konsol
        public void TampilkanSemuaArea()
        {
            var listArea = GetAllArea();

            // Cek jika tidak ada area terdaftar
            if (listArea.Count == 0)
            {
                Console.WriteLine("Belum ada area yang terdaftar.");
                return;
            }

            Console.WriteLine("Daftar Area Pengambilan Sampah:");
            foreach (var area in listArea)
            {
                Console.WriteLine($"ID: {area.Id} | Nama Area: {area.Area}");
            }
        }

        // Fungsi static untuk input area baru melalui console
        public static void DaftarkanAreaPengambilan()
        {
            Console.Write("Masukkan nama area baru: ");
            string namaAreaBaru = Console.ReadLine();

            // Validasi input tidak kosong/null
            if (string.IsNullOrWhiteSpace(namaAreaBaru))
            {
                Console.WriteLine("Nama area tidak boleh kosong.");
                return;
            }

            ConfigPendaftaranArea areaConfig = new ConfigPendaftaranArea();
            List<ConfigPendaftaranArea> daftarArea = areaConfig.GetAllArea();

            // Cek apakah area sudah terdaftar
            if (daftarArea.Any(a => a.Area != null &&
                                    a.Area.Equals(namaAreaBaru, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Area sudah terdaftar. Silakan masukkan nama area yang berbeda.");
            }
            else
            {
                // Simpan area baru
                ConfigPendaftaranArea areaBaru = new ConfigPendaftaranArea
                {
                    Area = namaAreaBaru
                };

                areaBaru.SaveArea();
            }
        }
    }
}

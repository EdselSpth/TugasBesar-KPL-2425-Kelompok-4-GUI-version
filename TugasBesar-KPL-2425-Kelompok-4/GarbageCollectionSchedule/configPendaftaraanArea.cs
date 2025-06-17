using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule
{
    public class configPendaftaraanArea
    {
        private readonly string configPath;

        public int id { get; set; }
        public string area { get; set; }

        // Constructor default
        public configPendaftaraanArea()
        {
            configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "daftarAreaFix.json");
        }

        // Constructor dengan custom path
        public configPendaftaraanArea(string customPath)
        {
            configPath = customPath;
        }

        public List<configPendaftaraanArea> GetAllArea()
        {
            List<configPendaftaraanArea> listArea = new();

            try
            {
                if (File.Exists(configPath))
                {
                    string read = File.ReadAllText(configPath);
                    if (!string.IsNullOrWhiteSpace(read))
                    {
                        listArea = JsonSerializer.Deserialize<List<configPendaftaraanArea>>(read) ?? new List<configPendaftaraanArea>();
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

        public void saveArea()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.area))
                {
                    Console.WriteLine("Nama area tidak valid.");
                    return;
                }

                var listArea = GetAllArea();

                if (listArea.Any(a => a.area != null &&
                                      a.area.Equals(this.area, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Area sudah ada. Tidak disimpan ulang.");
                    return;
                }

                int maxId = listArea.Any() ? listArea.Max(a => a.id) : 0;
                this.id = maxId + 1;
                listArea.Add(this);

                string newData = JsonSerializer.Serialize(listArea, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(configPath, newData);
                Console.WriteLine("Data Area berhasil disimpan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat menyimpan data area.");
                Console.WriteLine($"Detail: {ex.Message}");
            }
        }

        public void TampilkanSemuaArea()
        {
            var listArea = GetAllArea();

            if (listArea.Count == 0)
            {
                Console.WriteLine("Belum ada area yang terdaftar.");
                return;
            }

            Console.WriteLine("Daftar Area Pengambilan Sampah:");
            foreach (var area in listArea)
            {
                Console.WriteLine($"ID: {area.id} | Nama Area: {area.area}");
            }
        }

        public static void DaftarkanAreaPengambilan()
        {
            Console.Write("Masukkan nama area baru: ");
            string namaAreaBaru = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(namaAreaBaru))
            {
                Console.WriteLine("Nama area tidak boleh kosong.");
                return;
            }

            configPendaftaraanArea areaConfig = new configPendaftaraanArea();
            List<configPendaftaraanArea> daftarArea = areaConfig.GetAllArea();

            if (daftarArea.Any(a => a.area != null && a.area.Equals(namaAreaBaru, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Area sudah terdaftar. Silakan masukkan nama area yang berbeda.");
            }
            else
            {
                configPendaftaraanArea areaBaru = new configPendaftaraanArea
                {
                    area = namaAreaBaru
                };
                areaBaru.saveArea();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelLibrary;
using JadwalAPI;
using JadwalAPI.Model;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;
using System.Reflection;
using System.Globalization;
using System.Text.Json.Serialization;

namespace TugasBesar_KPL_2425_Kelompok_4.GarbageCollectionSchedule
{
    public static class JadwalService
    {
        private static readonly HttpClient _http = new HttpClient { BaseAddress = new Uri("https://localhost:7277/") };

        public static void CreateAndSendJadwal(DateOnly tanggal, List<JenisSampah> jenisList, string namaKurir, string area)
        // method untuk membuat dan mengirim jadwal pengambilan sampah ke API
        {
            if (jenisList == null || jenisList.Count == 0)
                throw new ArgumentException("Daftar jenis sampah tidak boleh kosong.", nameof(jenisList));

            var invalid = jenisList.Where(j => !RulesJadwal.pengambilanValidasi(j, tanggal.ToDateTime(TimeOnly.MinValue))).ToList();
            if (invalid.Any())
                throw new InvalidOperationException($"Jenis sampah berikut tidak dijadwalkan pada {tanggal.DayOfWeek}: {string.Join(", ", invalid)}.");

            var model = new JadwalModel
            {
                Tanggal = tanggal,
                JenisSampah = jenisList.Select(j => j.ToString()).ToList(),
                namaKurir = namaKurir ?? string.Empty,
                areaDiambil = area ?? string.Empty
            };

            var fileName = $"jadwal_{tanggal:yyyyMMdd}.json";
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            };

            List<JadwalModel> semuaJadwal;

            if (File.Exists(fileName))
            {
                var existingJson = File.ReadAllText(fileName).Trim();
                if (existingJson.StartsWith("["))
                {
                    semuaJadwal = JsonSerializer.Deserialize<List<JadwalModel>>(existingJson, options)
                                  ?? new List<JadwalModel>();
                }
                else if (existingJson.StartsWith("{"))
                {
                    var single = JsonSerializer.Deserialize<JadwalModel>(existingJson, options);
                    semuaJadwal = single != null
                        ? new List<JadwalModel> { single }
                        : new List<JadwalModel>();
                }   
                else
                {
                    semuaJadwal = new List<JadwalModel>();
                }
            }
            else
            {
                semuaJadwal = new List<JadwalModel>();
            }

            semuaJadwal.Add(model);

            var arrayJson = JsonSerializer.Serialize(semuaJadwal, options);
            File.WriteAllText(fileName, arrayJson);
            Console.WriteLine($"Tersimpan ke file {fileName} (total {semuaJadwal.Count} entri)");

            var response = _http.PostAsJsonAsync("api/jadwal_admin", model).Result;
            response.EnsureSuccessStatusCode();
            Console.WriteLine("Data berhasil dikirim ke API.");
        }



        public static JadwalModel GetJadwalByKurirDanTanggal(string namaKurir, DateOnly tanggal)
        // method untuk mendapatkan jadwal dari kurir dan tanggal
        {
            var response = _http.GetAsync("api/jadwal_admin").Result;
            if (!response.IsSuccessStatusCode) return null;
            var json = response.Content.ReadAsStringAsync().Result;
            var list = JsonSerializer.Deserialize<List<JadwalModel>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return list?.FirstOrDefault(j => j.namaKurir.Equals(namaKurir, StringComparison.OrdinalIgnoreCase) && j.Tanggal == tanggal);
        }

        public static void UpdateJadwal(DateOnly tanggal, List<JenisSampah> jenisList, string namaKurirBaru, string area, string namaKurirLama)
        {
            var model = GetJadwalByKurirDanTanggal(namaKurirLama, tanggal);
            if (model == null)
                throw new InvalidOperationException($"Jadwal untuk kurir '{namaKurirLama}' pada tanggal {tanggal:yyyy-MM-dd} tidak ditemukan.");

            var invalid = jenisList
                .Where(j => !RulesJadwal.pengambilanValidasi(j, tanggal.ToDateTime(TimeOnly.MinValue)))
                .ToList();
            if (invalid.Any())
                throw new InvalidOperationException($"Jenis sampah berikut tidak dijadwalkan pada {tanggal.DayOfWeek}: {string.Join(", ", invalid)}.");

            model.JenisSampah = jenisList.Select(j => j.ToString()).ToList();
            model.areaDiambil = area;
            model.namaKurir = namaKurirBaru;

            var response = _http.PutAsJsonAsync($"api/jadwal_admin/{tanggal:yyyy-MM-dd}", model).Result;
            response.EnsureSuccessStatusCode();
            Console.WriteLine("Data berhasil diupdate ke API.");

            var fileName = $"jadwal_{tanggal:yyyyMMdd}.json";
            File.WriteAllText(fileName, JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true }));
            Console.WriteLine($"File lokal {fileName} berhasil diperbarui.\n");
        }
    }
}

public class DateOnlyJsonConverter : JsonConverter<DateOnly>
{
    private const string Format = "yyyy-MM-dd";

    public override DateOnly Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    {
        var s = reader.GetString() ?? throw new JsonException("Expected date string");
        return DateOnly.ParseExact(s, Format, CultureInfo.InvariantCulture);
    }
     
    public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.ToString(Format));
}
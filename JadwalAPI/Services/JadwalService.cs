using System;
using System.Collections.Generic;
using System.Linq;
using JadwalAPI.Configuration;
using JadwalAPI.Model;
using Microsoft.Extensions.Options;
using modelLibrary;

namespace JadwalAPI.Services
{
    public class JadwalService : IJadwalService
    {
        private readonly JadwalSettings _settings;
        private readonly List<JadwalModel> _jadwalList;

        public JadwalService(IOptions<JadwalSettings> settings)
        {
            _settings = settings.Value;

            _jadwalList = new List<JadwalModel>
            {
                new JadwalModel { Tanggal = DateOnly.FromDateTime(DateTime.Now), JenisSampah = new List<string> { JS(JenisSampah.Organik) }, namaKurir = "Andi", areaDiambil = "Buahbatu" },
                new JadwalModel { Tanggal = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), JenisSampah = new List<string> { JS(JenisSampah.Plastik) }, namaKurir = "Budi", areaDiambil = "Bojongsoang" },
                new JadwalModel { Tanggal = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), JenisSampah = new List<string> { JS(JenisSampah.Kertas) }, namaKurir = "Joko", areaDiambil = "Cimahi" },
                new JadwalModel { Tanggal = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), JenisSampah = new List<string> { JS(JenisSampah.Logam) }, namaKurir = "Oka", areaDiambil = "Pasirkoja" },
                new JadwalModel { Tanggal = DateOnly.FromDateTime(DateTime.Now.AddDays(4)), JenisSampah = new List<string> { JS(JenisSampah.Elektronik) }, namaKurir = "Eka", areaDiambil = "Gedebage" },
                new JadwalModel { Tanggal = DateOnly.FromDateTime(DateTime.Now.AddDays(5)), JenisSampah = new List<string> { JS(JenisSampah.BahanBerbahaya) }, namaKurir = "Herawan", areaDiambil = "Kiaracondong" },
                new JadwalModel { Tanggal = DateOnly.FromDateTime(DateTime.Now.AddDays(6)), JenisSampah = new List<string> { JS(JenisSampah.Minyak) }, namaKurir = "Tono", areaDiambil = "Ciganitri" }
            };
        }

        public List<JadwalModel> GetAll() => _jadwalList;

        public List<JadwalModel> GetByTanggal(DateOnly tanggal) =>
            _jadwalList.Where(j => j.Tanggal == tanggal).ToList();

        public bool TambahJadwal(JadwalModel jadwal)
        {
            if (jadwal.JenisSampah != null)
            {
                var invalidSampah = jadwal.JenisSampah.Where(s => !IsValidJenisSampah(s)).ToList();
                if (invalidSampah.Any())
                    return false; // Tolak jika ada jenis sampah tidak valid
            }

            if (string.IsNullOrWhiteSpace(jadwal.areaDiambil))
                jadwal.areaDiambil = _settings.DefaultArea;

            _jadwalList.Add(jadwal);
            return true;
        }

        public bool UpdateJadwal(DateOnly tanggal, JadwalModel updatedJadwal)
        {
            var existing = _jadwalList.FirstOrDefault(j => j.Tanggal == tanggal);
            if (existing == null) return false;

            if (updatedJadwal.JenisSampah != null)
            {
                var invalidSampah = updatedJadwal.JenisSampah.Where(js => !IsValidJenisSampah(js)).ToList();
                if (invalidSampah.Any())
                    return false; // Tolak jika ada jenis sampah tidak valid
            }
            else
            {
                updatedJadwal.JenisSampah = new List<string> { JS(JenisSampah.Organik) };
            }

            existing.JenisSampah = updatedJadwal.JenisSampah;
            existing.namaKurir = updatedJadwal.namaKurir;
            existing.areaDiambil = string.IsNullOrWhiteSpace(updatedJadwal.areaDiambil)
                ? _settings.DefaultArea
                : updatedJadwal.areaDiambil;

            return true;
        }

        public bool HapusJadwal(DateOnly tanggal)
        {
            var existing = _jadwalList.FirstOrDefault(j => j.Tanggal == tanggal);
            if (existing == null) return false;

            _jadwalList.Remove(existing);
            return true;
        }

        public List<string> GetSemuaJenisSampah() => Enum.GetNames(typeof(JenisSampah)).ToList();

        private static string JS(JenisSampah jenis) => jenis.ToString();

        private static bool IsValidJenisSampah(string value) =>
            Enum.TryParse<JenisSampah>(value, true, out _);
    }
}

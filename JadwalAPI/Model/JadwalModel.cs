using System;
using System.Collections.Generic;
using modelLibrary;

namespace JadwalAPI.Model
{
    public class JadwalModel
    {
        public DateOnly Tanggal { get; set; }
        public List<string> JenisSampah { get; set; } = new();
        public string namaKurir { get; set; } = string.Empty;
        public string areaDiambil { get; set; } = string.Empty;
        public string Hari => Tanggal.DayOfWeek.ToString();

        public static JadwalModel buatJadwal(DateOnly tanggal, List<string> listJenisSampah, string namaKurir, string namaArea)
        {
            if (string.IsNullOrWhiteSpace(namaKurir))
            {
                throw new ArgumentException("Nama kurir tidak boleh kosong.");
            }

            if (listJenisSampah == null || !listJenisSampah.Any()) { 
                throw new ArgumentException("Jenis sampah harus diisi.");
            }

            return new JadwalModel
            {
                Tanggal = tanggal,
                JenisSampah = listJenisSampah,
                namaKurir = namaKurir,
                areaDiambil = namaArea ?? "Default Area"
            };
        }
    }
}


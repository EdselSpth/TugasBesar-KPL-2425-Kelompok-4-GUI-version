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
    }
}


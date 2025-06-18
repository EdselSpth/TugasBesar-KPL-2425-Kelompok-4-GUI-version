using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelLibrary
{
    public static class JadwalFactory
    {
        public static Jadwal<string> BuatJadwal(
            DateOnly tanggal,
            List<string> jenisSampah,
            string kurir,
            string areaDiambil
        )
        // Method untuk membuat objek Jadwal dengan validasi input design pattern factory method
        {
            if (kurir == null || string.IsNullOrWhiteSpace(kurir))
                throw new ArgumentException("Kurir tidak boleh kosong/null.");

            if (jenisSampah == null || jenisSampah.Count == 0)
                throw new ArgumentException("Jenis sampah harus diisi.");

            areaDiambil ??= "Default Area";

            return new Jadwal<string>(tanggal, jenisSampah, kurir, areaDiambil);
        }
    }
}

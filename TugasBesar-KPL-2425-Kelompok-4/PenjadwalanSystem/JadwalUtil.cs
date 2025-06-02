using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelLibrary;
using JadwalAPI;

namespace TugasBesar_KPL_2425_Kelompok_4.PenjadwalanSystem
{
    public static class JadwalUtil
    {
        public static JadwalModel ToModel(Jadwal<JenisSampah> jadwal)
        {
            return new JadwalModel
            {
                Tanggal = jadwal.Tanggal,
                JenisSampah = jadwal.JenisSampah.Select(j => j.ToString()).ToList(),
                namaKurir = jadwal.NamaKurir,
                areaDiambil = jadwal.AreaDiambil
            };
        }

        public static Jadwal<JenisSampah> ToEntity(JadwalModel model)
        {
            var jenisSampah = model.JenisSampah
                .Select(js => Enum.Parse<JenisSampah>(js))
                .ToList();

            return Jadwal<JenisSampah>.BuatJadwal(
                model.Tanggal,
                jenisSampah,
                model.areaDiambil,
                model.namaKurir
            );
        }
    }
}

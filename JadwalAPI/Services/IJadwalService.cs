using System;
using System.Collections.Generic;
using JadwalAPI.Model;

namespace JadwalAPI.Services
{
    public interface IJadwalService
    {
        List<JadwalModel> GetAll();
        List<JadwalModel> GetByTanggal(DateOnly tanggal);
        bool TambahJadwal(JadwalModel jadwal);  // <-- ubah dari void ke bool
        bool UpdateJadwal(DateOnly tanggal, JadwalModel updatedJadwal);
        bool HapusJadwal(DateOnly tanggal);
        List<string> GetSemuaJenisSampah();
    }

}

namespace modelLibrary
{


    public class Jadwal
    {
        public DateOnly Tanggal { get; private set; }
        public List<String> JenisSampah { get; private set; }
        public string NamaKurir { get; private set; }
        public string AreaDiambil { get; private set; }

        private Jadwal(DateOnly tanggal, List<String> jenisSampah, string areaDiambil, string namaKurir)
        {
            Tanggal = tanggal;
            JenisSampah = jenisSampah;
            AreaDiambil = areaDiambil;
            NamaKurir = namaKurir;
        }

        public static Jadwal BuatJadwal(DateOnly tanggal, List<String> jenisSampah, string areaDiambil, string namaKurir)
        {
            if (string.IsNullOrWhiteSpace(namaKurir))
            {
                throw new ArgumentException("Nama kurir tidak boleh kosong.");
            }

            if (jenisSampah == null || !jenisSampah.Any())
            {
                throw new ArgumentException("Jenis sampah harus diisi.");
            }

            areaDiambil ??= "Default Area";

            return new Jadwal(tanggal, jenisSampah, areaDiambil, namaKurir);
        }
    }
    
}

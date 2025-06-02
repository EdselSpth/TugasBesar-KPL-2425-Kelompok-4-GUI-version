namespace modelLibrary
{
    public class Jadwal<T>
    {
        public DateOnly Tanggal { get; private set; }
        public List<T> JenisSampah { get; private set; }
        public string NamaKurir { get; private set; }
        public string AreaDiambil { get; private set; }

        private Jadwal(DateOnly tanggal, List<T> jenisSampah, string areaDiambil, string namaKurir)
        {
            Tanggal = tanggal;
            JenisSampah = jenisSampah;
            AreaDiambil = areaDiambil;
            NamaKurir = namaKurir;
        }

        public static Jadwal<T> BuatJadwal(DateOnly tanggal, List<T> jenisSampah, string areaDiambil, string namaKurir)
        {
            if (string.IsNullOrWhiteSpace(namaKurir))
                throw new ArgumentException("Nama kurir tidak boleh kosong.");

            if (jenisSampah == null || !jenisSampah.Any())
                throw new ArgumentException("Jenis sampah harus diisi.");

            areaDiambil ??= "Default Area";

            return new Jadwal<T>(tanggal, jenisSampah, areaDiambil, namaKurir);
        }
    }
}

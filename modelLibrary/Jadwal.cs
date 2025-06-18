namespace modelLibrary
{
    public class Jadwal<T>
    {
        public DateOnly tanggal { get; set; }
        public List<T> jenisSampahList { get; set; }
        public string kurirPengambil { get; set; }
        public string areaDiambil { get; set; }

        public string JenisSampahTerjadwal =>
       (jenisSampahList?.Any() ?? false) ? string.Join(", ", jenisSampahList) : "-";

        public Jadwal(DateOnly tanggalInput, List<T> jenisSampahListInput, string kurirPengambilInput, string areaDiambilInput)
        {
            tanggal = tanggalInput;
            jenisSampahList = jenisSampahListInput;
            kurirPengambil = kurirPengambilInput;
            areaDiambil = areaDiambilInput;
        }
    }
}

namespace modelLibrary
{
    public class Jadwal<T>
    {
        public DateOnly Tanggal { get; set; }
        public List<T> JenisSampahList { get; set; }
        public string KurirPengambil { get; set; }
        public string AreaDiambil { get; set; }

        public Jadwal(DateOnly tanggalInput, List<T> jenisSampahListInput, string kurirPengambilInput, string areaDiambilInput)
        {
            Tanggal = tanggalInput;
            JenisSampahList = jenisSampahListInput;
            KurirPengambil = kurirPengambilInput;
            AreaDiambil = areaDiambilInput;
        }
    }
}

using Microsoft.Extensions.Options;  // jangan lupa ini
using JadwalAPI.Configuration; // untuk JadwalSettings
using modelLibrary;
using JadwalAPI.Model;
using JadwalAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime;


namespace JadwalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Jadwal_Pengguna : ControllerBase
    {
        private readonly IJadwalService _jadwalService;
        private readonly JadwalSettings _settings;

        public Jadwal_Pengguna(IJadwalService jadwalService)
        {
            _jadwalService = jadwalService;
        }

        [HttpGet]
        public ActionResult<List<JadwalModel>> GetAll()
        {
            return Ok(_jadwalService.GetAll());
        }

        [HttpGet("{tanggal}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<List<JadwalModel>> GetByTanggal(string tanggal)
        {
            if (!DateOnly.TryParse(tanggal, out DateOnly parsedDate))
                return BadRequest("Format tanggal tidak valid. Gunakan format yyyy-MM-dd.");

            var jadwal = _jadwalService.GetByTanggal(parsedDate);
            if (jadwal == null)
                return NotFound("Jadwal tidak ditemukan.");

            return Ok(jadwal);
        }

        [HttpPost]
        [ProducesResponseType(typeof(JadwalModel), 201)]
        [ProducesResponseType(400)]
        public ActionResult AddJadwal([FromBody] JadwalModel jadwal)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Validasi jenis sampah
            var invalidSampah = jadwal.JenisSampah?
                .Where(s => !Enum.TryParse<JenisSampah>(s, true, out _))
                .ToList();

            if (invalidSampah != null && invalidSampah.Any())
                return BadRequest($"Jenis sampah tidak valid: {string.Join(", ", invalidSampah)}");

            // Set area default jika kosong
            if (string.IsNullOrWhiteSpace(jadwal.areaDiambil))
                jadwal.areaDiambil = _settings.DefaultArea;

            _jadwalService.TambahJadwal(jadwal);
            return CreatedAtAction(nameof(GetByTanggal), new { tanggal = jadwal.Tanggal.ToString("yyyy-MM-dd") }, jadwal);
        }

        [HttpDelete("{tanggal}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult DeleteJadwal(string tanggal)
        {
            if (!DateOnly.TryParse(tanggal, out DateOnly parsedDate))
                return BadRequest("Format tanggal tidak valid. Gunakan format yyyy-MM-dd.");

            bool success = _jadwalService.HapusJadwal(parsedDate);
            if (!success)
                return NotFound("Jadwal tidak ditemukan.");

            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;  // jangan lupa ini
using JadwalAPI.Model;
using JadwalAPI.Services;
using JadwalAPI.Configuration; // untuk JadwalSettings
using modelLibrary;

namespace JadwalAPI.Controllers
{
    [ApiController]
    [Route("api/jadwal_admin")]
    public class JadwalAdminController : ControllerBase
    {
        private readonly IJadwalService _jadwalService;
        private readonly JadwalSettings _settings;  // tambahkan field ini

        // Inject IOptions<JadwalSettings> di constructor
        public JadwalAdminController(IJadwalService jadwalService, IOptions<JadwalSettings> settings)
        {
            _jadwalService = jadwalService;
            _settings = settings.Value;  // inisialisasi _settings
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<JadwalModel>), 200)]
        public ActionResult<List<JadwalModel>> GetAll()
        {
            return Ok(_jadwalService.GetAll());
        }

        [HttpGet("{tanggal}")]
        [ProducesResponseType(typeof(List<JadwalModel>), 200)]
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

        [HttpPut("{tanggal}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult UpdateJadwal(string tanggal, [FromBody] JadwalModel updatedJadwal)
        {
            if (!DateOnly.TryParse(tanggal, out DateOnly parsedDate))
                return BadRequest("Format tanggal tidak valid. Gunakan format yyyy-MM-dd.");

            bool success = _jadwalService.UpdateJadwal(parsedDate, updatedJadwal);
            if (!success)
                return NotFound("Jadwal tidak ditemukan.");

            return NoContent();
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

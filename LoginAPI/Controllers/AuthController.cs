using LoginAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LoginAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // Simulasi database user (hanya 1 user default)
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Username = "admin", Password = "1234", Role = Role.Admin }
        };

        // Endpoint untuk login
        [HttpPost("login")]
        public IActionResult Login([FromBody] User loginUser)
        {
            // Mulai dari state awal
            var state = LoginState.Awal;

            // Pindah ke state validasi setelah klik submit
            state = StateBasedAuth.GetNextState(state, LoginTrigger.Submit);

            // Cek apakah username dan password valid
            state = StateBasedAuth.GetNextState(state,
                users.Any(u => u.Username == loginUser.Username && u.Password == loginUser.Password)
                ? LoginTrigger.Valid
                : LoginTrigger.Invalid);

            // Jika valid, kirim data user
            if (state == LoginState.Berhasil)
            {
                var user = users.First(u => u.Username == loginUser.Username);
                return Ok(new { message = "Login berhasil!", username = user.Username, role = user.Role });
            }
            else
            {
                // Jika tidak valid, kembalikan Unauthorized
                return Unauthorized(new { message = "Username atau password salah" });
            }
        }

        // Endpoint untuk register user baru
        [HttpPost("register")]
        public IActionResult Register([FromBody] User newUser)
        {
            // Validasi role harus salah satu dari enum Role
            if (!Enum.IsDefined(typeof(Role), newUser.Role))
            {
                return BadRequest(new { message = "Role tidak valid!! harus salah satu dari admin, kurir atau user" });
            }

            // Cek apakah username sudah dipakai
            var existingUser = users.FirstOrDefault(u => u.Username == newUser.Username);
            if (existingUser != null)
            {
                return Conflict(new { message = "Username sudah terdaftar" });
            }

            // Simpan user baru
            newUser.Id = users.Count + 1;
            users.Add(newUser);

            return Ok(new { message = "Register berhasil!", username = newUser.Username, role = newUser.Role });
        }
    }
}

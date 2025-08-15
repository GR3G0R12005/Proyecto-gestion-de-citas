using Aplicacion.Dto;
using Aplicacion.Interfaces;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class RegistroController : ControllerBase
    {
        private readonly IUsuarioServicio _usuarioServicio;

        public RegistroController(IUsuarioServicio usuarioServicio)
        {
            _usuarioServicio = usuarioServicio;
        }

        [HttpGet ("logearse")]
        public IActionResult Logearse(string correo, string contrasena)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = _usuarioServicio.Logearse(correo.ToLower(), contrasena);
            if (usuario == null)
            {
                return Unauthorized();
            }

            return Ok(usuario);
        }

        [HttpGet]
        public IActionResult ObtenerUsuarios()
        {
            return Ok(_usuarioServicio.ObtenerUsuarios());
        }

        [HttpPost]
        public IActionResult RegistrarUsuario([FromBody] UsuarioRegistro usuarioRegistro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = new Usuario
            {
                Nombre = usuarioRegistro.Nombre,
                Edad = usuarioRegistro.Edad,
                Correo = usuarioRegistro.Correo?.ToLower(),
                Contraseña = usuarioRegistro.Contraseña,
                Roll = usuarioRegistro.Roll
            };

            _usuarioServicio.RegistrarUsuario(usuario);
            return CreatedAtAction(nameof(ObtenerUsuarios), new { id = usuario.Id }, usuario);
        }
    }
}
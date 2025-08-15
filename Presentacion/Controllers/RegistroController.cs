using Aplicacion.Interfaces;
using Dominio.Entidades;
using Dominio.Interfaces;
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

        [HttpGet]
        public IActionResult ObtenerUsuarios()
        {
            return Ok(_usuarioServicio.ObtenerUsuarios());
        }
    }
}
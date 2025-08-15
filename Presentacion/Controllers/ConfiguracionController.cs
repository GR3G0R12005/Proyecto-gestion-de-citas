using Aplicacion.Dto;
using Aplicacion.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfiguracionController : ControllerBase
    {
        private readonly IConfiguracionService _service;

        public ConfiguracionController(IConfiguracionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var configs = await _service.ObtenerConfiguraciones();
            return Ok(configs);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ConfiguracionDto dto)
        {
            await _service.CrearConfiguracion(dto);
            return Ok(new { mensaje = "Configuración creada correctamente." });
        }
    }

}

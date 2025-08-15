using Aplicacion.Dto;
using Aplicacion.Interfaces;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicio
{
    public class ConfiguracionService : IConfiguracionService
    {
        private readonly IConfiguracionRepository _repo;

        public ConfiguracionService(IConfiguracionRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<ConfiguracionDto>> ObtenerConfiguraciones()
        {
            var configs = await _repo.GetAllAsync();
            return configs.Select(c => new ConfiguracionDto
            {
                Fecha = c.Fecha,
                Turno = c.Turno,
                HoraInicio = c.HoraInicio,
                HoraFin = c.HoraFin,
                DuracionCitaMinutos = c.DuracionCitaMinutos,
                EstacionesDisponibles = c.EstacionesDisponibles
            }).ToList();
        }

        public async Task CrearConfiguracion(ConfiguracionDto dto)
        {
            var config = new Configuracion
            {
                Fecha = dto.Fecha,
                Turno = dto.Turno,
                HoraInicio = dto.HoraInicio,
                HoraFin = dto.HoraFin,
                DuracionCitaMinutos = dto.DuracionCitaMinutos,
                EstacionesDisponibles = dto.EstacionesDisponibles
            };

            await _repo.AddAsync(config);
        }
    }

}

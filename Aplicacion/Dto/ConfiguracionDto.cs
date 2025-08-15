using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dto
{
    public class ConfiguracionDto
    {
        public DateTime Fecha { get; set; }
        public string? Turno { get; set; } 
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int DuracionCitaMinutos { get; set; }
        public int EstacionesDisponibles { get; set; }
    }

}

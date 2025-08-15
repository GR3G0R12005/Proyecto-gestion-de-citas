using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface IConfiguracionRepository
    {
        Task<List<Configuracion>> GetAllAsync();
        Task<Configuracion> GetByIdAsync(int id);
        Task AddAsync(Configuracion config);
        Task UpdateAsync(Configuracion config);
        Task DeleteAsync(int id);
    }

}

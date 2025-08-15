using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Persistencia.Repositorios
{
    using Aplicacion.Interfaces;
    using Dominio.Entidades;
    using global::Infraestructura.Contexto;
    using Microsoft.EntityFrameworkCore;

    namespace Infraestructura.Repositorios
    {
        public class ConfiguracionRepository : IConfiguracionRepository
        {
            private readonly P2Contexto _contexto;

            public ConfiguracionRepository(P2Contexto contexto)
            {
                _contexto = contexto;
            }

            public async Task<List<Configuracion>> GetAllAsync()
            {
                return await _contexto.Configuraciones.ToListAsync();
            }

            public async Task<Configuracion> GetByIdAsync(int id)
            {
                return await _contexto.Configuraciones.FindAsync(id);
            }

            public async Task AddAsync(Configuracion config)
            {
                _contexto.Configuraciones.Add(config);
                await _contexto.SaveChangesAsync();
            }

            public async Task UpdateAsync(Configuracion config)
            {
                _contexto.Configuraciones.Update(config);
                await _contexto.SaveChangesAsync();
            }

            public async Task DeleteAsync(int id)
            {
                var config = await _contexto.Configuraciones.FindAsync(id);
                if (config != null)
                {
                    _contexto.Configuraciones.Remove(config);
                    await _contexto.SaveChangesAsync();
                }
            }
        }
    }

}

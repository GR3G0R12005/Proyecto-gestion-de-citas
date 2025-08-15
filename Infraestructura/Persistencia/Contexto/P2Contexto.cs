using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Contexto
{
    public class P2Contexto : DbContext
    {
        public P2Contexto(DbContextOptions<P2Contexto> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
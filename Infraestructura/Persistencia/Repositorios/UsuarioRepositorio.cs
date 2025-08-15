using Dominio.Entidades;
using Dominio.Interfaces;
using Infraestructura.Contexto;

namespace Infraestructura.Persistencia.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRegistro
    {
        private readonly P2Contexto _contexto;

        public UsuarioRepositorio(P2Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<Usuario> GetUsuarios()
        {
            return _contexto.Usuario.ToList();
        }

        public void SetUsuario(Usuario usuario)
        {
            _contexto.Usuario.Add(usuario);
            _contexto.SaveChanges();
        }
    }
}
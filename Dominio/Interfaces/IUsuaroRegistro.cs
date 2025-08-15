using Dominio.Entidades;

namespace Dominio.Interfaces
{
    public interface IUsuarioRegistro
    {
        List<Usuario> GetUsuarios();
        public void SetUsuario(Usuario model);
    }
}
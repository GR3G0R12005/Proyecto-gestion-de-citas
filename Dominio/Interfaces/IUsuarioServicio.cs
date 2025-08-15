using Dominio.Entidades;

namespace Aplicacion.Interfaces
{
    public interface IUsuarioServicio
    {
        List<Usuario> ObtenerUsuarios();
        public void SetUsuario(Usuario model);
    }
}
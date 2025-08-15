using Dominio.Entidades;

namespace Aplicacion.Interfaces
{
    public interface IUsuarioServicio
    {
        List<Usuario> ObtenerUsuarios();
        public void RegistrarUsuario(Usuario model);
        public Usuario Logearse(string correo, string contrasena);
    }
}
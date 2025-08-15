using Aplicacion.Interfaces;
using Dominio.Entidades;
using Dominio.Interfaces;

namespace Aplicacion.Servicio
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private readonly IUsuarioRegistro _usuarioRegistro;

        public UsuarioServicio(IUsuarioRegistro usuarioRegistro)
        {
            _usuarioRegistro = usuarioRegistro;
        }

        public Usuario Logearse(string correo, string contrasena)
        {
            return _usuarioRegistro.GetUsuarios().FirstOrDefault(u => u.Correo == correo && u.Contraseña == contrasena)!;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return _usuarioRegistro.GetUsuarios().Select(u => new Usuario
            {
                Nombre = u.Nombre,
                Edad = u.Edad,
                Correo = u.Correo,
                Roll = u.Roll
            }).ToList();
        }

        public void RegistrarUsuario(Usuario model)
        {
            _usuarioRegistro.SetUsuario(model);
        }
        }
}

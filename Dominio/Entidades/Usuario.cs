using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Correo { get; set; }
        public string? Contraseña { get; set; }
        public string? Roll { get; set; }
    }
}
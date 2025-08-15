using Aplicacion.Interfaces;
using Aplicacion.Servicio;
using Dominio.Interfaces;
using Infraestructura.Contexto;
using Infraestructura.Persistencia.Repositorios;
using Infraestructura.Persistencia.Repositorios.Infraestructura.Repositorios;

namespace Presentacion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Base de datos
            builder.Services.AddSqlServer<P2Contexto>(builder.Configuration.GetConnectionString("AppConnection"));

            // Servicios y repositorios existentes
            builder.Services.AddScoped<IUsuarioServicio, UsuarioServicio>();
            builder.Services.AddScoped<IUsuarioRegistro, UsuarioRepositorio>();

            // Servicios y repositorios para Configuración
            builder.Services.AddScoped<IConfiguracionService, ConfiguracionService>();
            builder.Services.AddScoped<IConfiguracionRepository, ConfiguracionRepository>();

            var app = builder.Build();

            // Middleware
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}

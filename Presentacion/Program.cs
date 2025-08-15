
using Aplicacion.Interfaces;
using Aplicacion.Servicio;
using Dominio.Interfaces;
using Infraestructura.Contexto;
using Infraestructura.Persistencia.Repositorios;

namespace Presentacion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSqlServer<P2Contexto>(builder.Configuration.GetConnectionString("AppConnection"));

            builder.Services.AddScoped<IUsuarioServicio, UsuarioServicio>();
            builder.Services.AddScoped<IUsuarioRegistro, UsuarioRepositorio>();
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
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

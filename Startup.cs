using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Asp.NetCoreMySecondApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Agrega todas las clases que los controladores necesitan para funcionar
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Aqui nos dice que usa ruteo osea un endpoint /api/users
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //Recordemos que este metodo de endpoints requiere de dependencias y eso es el serviceAddController
                //Todas las clases que hereden de base controller o controller seran agarradas por MapController
                //Aqui toma el midleware y lo pasa como ruta osea nos esta configurando un template como ruta
                // nombre del controlador, nombre de la vista  que sea la accion y el id que es opcional
                endpoints.MapControllers();

                //Aqui quitaremos este mapeo de rutas ya que no lo necesitamos
                /* endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });*/
            }); 
        }
    }
}

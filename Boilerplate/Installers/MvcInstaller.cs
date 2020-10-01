using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boilerplate.API.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Boilerplate",
                    Description = "A simple example ASP.NET Core Web API with vue.js",
                    Contact = new OpenApiContact
                    {
                        Name = "Kevin Hernandez",
                        Email = "kev.hdez05@gmail.com",
                        Url = new Uri("https://kevin-hernandez.works/"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under MIT",
                        Url = new Uri("https://example.com/license"),
                    }
                });
            });

            services.AddControllers();
        }
    }
}

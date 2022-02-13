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
                    Title = "awesome-boilerplate-netcore",
                    Description = "This is a boilerplate made with Net Core 3.1 and Entity Framework, thinking on speed developing time when creating new .Net Core's projects.",
                    Contact = new OpenApiContact
                    {
                        Name = "Kevin Hernandez",
                        Email = "kev.hdez05@gmail.com",
                        Url = new Uri("https://kevinhernandez.work/"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Licence under WTFPL",
                        Url = new Uri("https://choosealicense.com/licenses/wtfpl/"),
                    }
                });
            });

            services.AddControllers();
        }
    }
}

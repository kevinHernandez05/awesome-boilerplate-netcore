using Boilerplate.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boilerplate.API.Installers
{
    public class DataInstallers : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            //DI
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();

            // automapper

        }
    }
}

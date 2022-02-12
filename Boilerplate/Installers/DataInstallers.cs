using Boilerplate.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boilerplate.Service.Helpers.jwt;
using Boilerplate.Service.WeatherForecast;
using Boilerplate.Service.User;

namespace Boilerplate.API.Installers
{
    public class DataInstallers : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            //Registering DBContext
            services.AddDbContext<ApplicationDbContext>(opt => 
                opt.UseSqlServer(configuration.GetConnectionString("DatabaseConnection")));

            //DI
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
            services.AddTransient<IUserService, UserService>();

            //JWT Setting
            services.Configure<AppSettings>(configuration.GetSection("AppSettings"));


            // automapper

        }
    }
}

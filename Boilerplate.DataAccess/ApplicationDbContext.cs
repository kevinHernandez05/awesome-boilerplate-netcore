using Boilerplate.Model.Entities.WeatherForecast;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Boilerplate.DataAccess
{
    /*
     * To add a new migration:
     * 
     * Initial: 
     *                       .NET CLI → dotnet-ef migrations add Initial
     *  NuGet Package Manager Console → Add-Migration Initial
     * 
     * Create and update the Database:
     * 
     *                       .NET CLI → dotnet-ef database update
     *  NuGet Package Manager Console → Update-Database
     *  
     * 
     */

    //DBContext
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public virtual DbSet<WeatherForecastEntity> WeatherForecast { get; set; }
        
    }

    //DBContextResolver
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/../Boilerplate/appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("DatabaseConnection");
            builder.UseSqlServer(connectionString);
            return new ApplicationDbContext(builder.Options);
        }
    }

}

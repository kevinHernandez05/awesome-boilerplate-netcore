using Boilerplate.Model.Entities.WeatherForecast;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Boilerplate.Service.WeatherForecast
{
    public class WeatherForecastService : IWeatherForecastService
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecastEntity> GetAllWeatherForecast()
        {
            var rng = new Random();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecastEntity
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

    }
}

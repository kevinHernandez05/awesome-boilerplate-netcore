using Boilerplate.Entities.WeatherForecast;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boilerplate.Service
{
    public interface IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> GetAllWeatherForecast();

    }
}

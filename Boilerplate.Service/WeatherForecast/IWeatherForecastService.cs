using Boilerplate.Model.Entities.WeatherForecast;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boilerplate.Service.WeatherForecast
{
    public interface IWeatherForecastService
    {
        public IEnumerable<WeatherForecastEntity> GetAllWeatherForecast();

    }
}

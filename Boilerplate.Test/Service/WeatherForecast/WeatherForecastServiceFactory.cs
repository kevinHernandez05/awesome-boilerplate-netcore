using Boilerplate.Service;
using Boilerplate.Service.WeatherForecast;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boilerplate.Test.Service.WeatherForecast
{
    public class WeatherForecastServiceFactory
    {

        internal static IWeatherForecastService GetService()
        {

            return new WeatherForecastService();

        }


    }
}

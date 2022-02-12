using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boilerplate.Model.Entities.WeatherForecast;
using Boilerplate.Service.WeatherForecast;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Boilerplate.API.Controllers.WeatherForecast
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecastEntity> Get()
        {
            return _weatherForecastService.GetAllWeatherForecast();

        }
    }
}

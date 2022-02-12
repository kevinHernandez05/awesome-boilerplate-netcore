using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Boilerplate.Test.Controller.WeatherForecast
{

    public class WeatherForecastControllerTest
    {
        [Fact]
        public void Test_Get_Found_Example()
        {
            int cantidad = 2;
            var service = WeatherForecastControllerFactory.GetMock();
            var controller = WeatherForecastControllerFactory.GetController(service);
            var result = controller.Get();

            Assert.IsType<Model.Entities.WeatherForecast.WeatherForecast>
                (result.FirstOrDefault());
            Assert.IsAssignableFrom<Model.Entities.WeatherForecast.WeatherForecast>
                (result.FirstOrDefault());

            Assert.Equal(cantidad, result.Count());
        }

        [Fact]
        public void Test_Get_NotFound_Example()
        {
            int cantidad = 0;
            var service = WeatherForecastControllerFactory.GetMockNotFound();
            var controller = WeatherForecastControllerFactory.GetController(service);
            var result = controller.Get();

            Assert.IsType<List<Model.Entities.WeatherForecast.WeatherForecast>>(result);
            Assert.IsAssignableFrom<List<Model.Entities.WeatherForecast.WeatherForecast>>(result);
            Assert.Equal(cantidad, result.Count());
        }
    }
}

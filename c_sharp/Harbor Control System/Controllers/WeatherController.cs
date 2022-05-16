using Harbor_Control_System.Entity;
using Harbor_Control_System.Exception_Handling;
using Harbor_Control_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Harbor_Control_System.Controllers
{
    public class WeatherController : Controller
    {
        public WeatherController()
        {
            try
            {
                Weather = WeatherService.GetWeather().Result;
            }
            catch (WeatherException)
            {

                throw new WeatherException("Please check you internet connection");
            }
        }

        public Weather Weather { get; }

    }
}

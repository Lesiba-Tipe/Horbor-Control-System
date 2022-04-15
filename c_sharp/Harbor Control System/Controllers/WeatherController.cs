using Microsoft.AspNetCore.Mvc;
using Harbor_Control_System.Services;
using Harbor_Control_System.Entity;

namespace Harbor_Control_System.Controllers
{
    public class WeatherController : Controller
    {
        public WeatherController()
        {
            Weather = WeatherService.GetWeather().Result;
        }

        public Weather Weather { get; }

    }
}

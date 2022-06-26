using HoborControlSystem.Entity;
using HoborControlSystem.Exception_Handling;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HoborControlSystem.Services
{
    public class WeatherService
    {
        public static async Task<Weather> GetWeather()
        {
            try
            {
                var client = new HttpClient();
                Weather weather;
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://community-open-weather-map.p.rapidapi.com/climate/month?q=Johannesburg"),
                    Headers =
                    {
                        { "X-RapidAPI-Host", "community-open-weather-map.p.rapidapi.com" },
                        { "X-RapidAPI-Key", "c51366e702mshbd652685e2218d7p1dfc79jsne74f01ade317" }, //Use Azure vaultKey to store this key
                    },
                };

                using (var response = await client.SendAsync(request))
                {

                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    var weatherApi = JsonConvert.DeserializeObject<WeatherApi>(body);


                    if (weatherApi.cod == 200)
                    {
                        var forecast = weatherApi.list
                            .Select(forecast => new Forecast()
                            {
                                Humadity = forecast.humadity,
                                Pressure = forecast.pressure,
                                Temperature = new Temperature()
                                {
                                    Average = forecast.temp.average,
                                    MinAverage = forecast.temp.averge_min,
                                    MaxAverage = forecast.temp.average_max
                                },
                                WindSpeed = forecast.wind_speed
                            }).ToList();

                        weather = new Weather()
                        {
                            StatusCode = weatherApi.cod,
                            City = new City()
                            {
                                Name = weatherApi.city.name,
                                Country = weatherApi.city.country,
                                Coordinates = new Coordinates()
                                {
                                    Latitude = weatherApi.city.coord.lat,
                                    Longitude = weatherApi.city.coord.lon
                                }


                            },
                            Message = weatherApi.message,
                            Forecast = forecast
                        };
                        return weather;
                    }
                }
            }
            catch (Exception)
            {
                throw new WeatherException("Please connect to internet");
            }

            return null;
        }



    }


}

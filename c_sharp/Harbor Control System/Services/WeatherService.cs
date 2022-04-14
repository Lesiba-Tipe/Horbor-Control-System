using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Harbor_Control_System.Entity;

namespace Harbor_Control_System.Services
{
    public class WeatherService
    {
        public async Task<WeatherApi> GetWeather()
        {
            var client = new HttpClient();
            WeatherApi weatherApi;
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://community-open-weather-map.p.rapidapi.com/climate/month?q=San%20Francisco"),
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

                weatherApi = JsonConvert.DeserializeObject<WeatherApi>(body);

            }

            return weatherApi;
        }
    }

   
}

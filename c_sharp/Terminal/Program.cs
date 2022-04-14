using System;
using System.Net.Http;

namespace Terminal
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://community-open-weather-map.p.rapidapi.com/climate/month?q=San%20Francisco"),
				Headers =
					{
						{ "X-RapidAPI-Host", "community-open-weather-map.p.rapidapi.com" },
						{ "X-RapidAPI-Key", "c51366e702mshbd652685e2218d7p1dfc79jsne74f01ade317" },
					},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				Console.WriteLine(body);
			}
			Console.WriteLine("Hello World!");
        }
    }
}

using Facade.Models;
using Facade.Models.OpenWeather;
using Newtonsoft.Json;

namespace Facade.Web
{
    internal static class ApiClient
    {
        static HttpClient client = new HttpClient();

        public static async Task<WeatherResult> GetWeather(ConnectionItems connItems)
        {
            WeatherResult weatherResult = null;
            var response = await client.GetAsync(connItems.GetUrl());
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var fullTime = JsonConvert.DeserializeObject<Root>(json);   
                weatherResult = fullTime.weather.FirstOrDefault();
            }
            return weatherResult;
        }
    }
}

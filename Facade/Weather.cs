using Facade.Helpers;
using Facade.Models.OpenWeather;
using Facade.WeatherClient;
using System.Runtime.Serialization;

namespace Facade
{
    public enum Origin
    {
        [StringValue("OpenWeatherMapClient")]
        OpenWeatherMap,
    } 

    public static class Weather
    {
        public static async Task<WeatherResult> GetWeatherByLatLong(double latitude, double longitude, Origin origin)
        {
            IWeatherClient client = WeatherFactory.GetInstance(origin.GetStringValue());
            return await client.GetWeather(latitude, longitude);
        }
    }
}
using Facade.Models;
using Facade.Models.OpenWeather;

namespace Facade.WeatherClient
{
    internal interface IWeatherClient
    {
        protected string Origin { get; }
        protected double Latitude { get; set; }
        protected double Longitude { get; set; }
        protected string Key { get; }

        public ConnectionItems GetConnectionItems();
        public Task<WeatherResult> GetWeather(double latitude, double longitude);
    }
}

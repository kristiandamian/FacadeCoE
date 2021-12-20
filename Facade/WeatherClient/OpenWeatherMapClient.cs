using Facade.Models;
using Facade.Models.OpenWeather;
using Facade.Web;

namespace Facade.WeatherClient
{
    internal class OpenWeatherMapClient : IWeatherClient
    {
        public string Origin {  get; private set; } = "https://api.openweathermap.org/data/2.5/weather";
        public double Latitude {  get; set; }
        public double Longitude {  get; set; }
        public string Key {  get; private set; } = "MOCK_API_KEY_CHANGE_TO_REAL";

        public ConnectionItems GetConnectionItems()
        {
            return new ConnectionItems {
                Origin    = this.Origin,
                Latitude  = this.Latitude,
                Longitude = this.Longitude,
                Key       = this.Key
            };
        }

        public async Task<WeatherResult> GetWeather(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            return await ApiClient.GetWeather(GetConnectionItems());
        }
    }
}

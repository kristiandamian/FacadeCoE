namespace Facade.Models
{
    internal class ConnectionItems
    {
        public string Origin { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Key { get; set; }

        public string GetUrl()
        {
            return $"{Origin}?lat={Latitude}&lon={Longitude}&appid={Key}";
        }
    }
}

// See https://aka.ms/new-console-template for more information
using Facade;

var latitude = 0;
var longitude = 0;
var weather = await Weather.GetWeatherByLatLong(latitude, longitude, Origin.OpenWeatherMap);
Console.WriteLine(weather.Main);
Console.WriteLine(weather.Description);

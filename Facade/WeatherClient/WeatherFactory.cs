namespace Facade.WeatherClient
{
    static internal class WeatherFactory
    {
       public static IWeatherClient GetInstance(string strFullyQualifiedName) 
        {         
             Type t = Type.GetType($"Facade.WeatherClient.{strFullyQualifiedName}"); 
             return  Activator.CreateInstance(t) as IWeatherClient;         
        }
    }
}

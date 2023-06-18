namespace MyRazorViewsApp.Models
{
    public class CityWeatherWithDict
    {
        public Dictionary<string, CityWeather> weathers { get; set; } 
            = new Dictionary<string, CityWeather>();
        
    }
}

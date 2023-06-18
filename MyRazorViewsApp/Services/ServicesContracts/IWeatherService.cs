using MyRazorViewsApp.Models;

namespace Services.ServicesContracts
{
    public interface IWeatherService
    {

        List<CityWeather> GetWeatherDetails();
        CityWeather? GetWeatherByCityCode(string CityCode);
    }
}

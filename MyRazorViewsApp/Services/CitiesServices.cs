using MyRazorViewsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Services.ServicesContracts;

namespace Services
{
    public class CitiesServices : IWeatherService
    {
        public List<CityWeather> weathers = new List<CityWeather>()
        {
            new CityWeather() {
                    CityUniqueCode = "LDN",
                    CityName = "London",
                    DateAndTime = DateTime.Parse("2030-01-01 8:00"),
                    TemperatureFahrenheit = 88
            },

            new CityWeather(){
                CityUniqueCode = "NYC",
                CityName = "New York",
                DateAndTime = DateTime.Parse("2030-01-01 3:00"),
                TemperatureFahrenheit = 30
            },

            new CityWeather()
            {
                CityUniqueCode = "PAR",
                CityName = "Paris",
                DateAndTime = DateTime.Parse("2030-01-01 9:00"),
                TemperatureFahrenheit = 52
            }
        };
        public CityWeatherWithDict cityWeatherWithDict = new CityWeatherWithDict();

        public CitiesServices()
        {
            foreach (CityWeather city in weathers)
            {
                cityWeatherWithDict.weathers.Add(city.CityUniqueCode, city);
            }
        }

        public List<CityWeather> GetWeatherDetails() 
        {
            return weathers;
        }

        public CityWeather? GetWeatherByCityCode(string CityCode) 
        {

            if (cityWeatherWithDict.weathers.ContainsKey(CityCode))
            {
                return cityWeatherWithDict.weathers[CityCode];
            }
            else 
            {
                return null;
            }

        }

    }
}
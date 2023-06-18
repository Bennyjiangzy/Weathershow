using Microsoft.AspNetCore.Mvc;
using MyRazorViewsApp.Models;
using Services.ServicesContracts;

namespace MyRazorViewsApp.Controllers
{
    public class Weather : Controller
    {
        private readonly IWeatherService _weatherService;

        public Weather(IWeatherService weatherService) 
        {
            _weatherService = weatherService;
        }

        [Route("/")]
        public IActionResult Index()
        {

            return View(_weatherService.GetWeatherDetails());
        }

        [Route("/weather/{citycode}")]
        public IActionResult Details()
        {
            string cityCode = Convert.ToString(Request.RouteValues["citycode"])!;
            CityWeather? city = _weatherService.GetWeatherByCityCode(cityCode);
            if (city != null)
            {
                return View(city);
            }
            return View("Error");
        }
    }
}

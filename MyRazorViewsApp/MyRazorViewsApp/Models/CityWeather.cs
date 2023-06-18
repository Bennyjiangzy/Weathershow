using System.ComponentModel.DataAnnotations;

namespace MyRazorViewsApp.Models
{
    public class CityWeather
    {
        [Required]
        public string? CityUniqueCode { get; set; }

        [Required]
        public string? CityName { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }

        [Required]
        public int TemperatureFahrenheit { get; set; }
    }
}

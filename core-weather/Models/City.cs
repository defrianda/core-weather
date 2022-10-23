using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core_weather.Models
{
    public class City
    {
        [Display(Name = "City Name : ")]
        public string Name { get; set; }

        [Display(Name = "Longitude : ")]
        public float Longitude { get; set; }

        [Display(Name = "Latitude : ")]
        public float Latitude { get; set; }

        [Display(Name = "Date Time : ")]
        public DateTime DateTime { get; set; }

        [Display(Name = "Wind : ")]
        public float Wind { get; set; }

        [Display(Name = "Visibility : ")]
        public float Visibility { get; set; }

        [Display(Name = "Weather : ")]
        public string Weather { get; set; }

        [Display(Name = "Sky Conditions : ")]
        public string SkyConditions { get; set; }

        [Display(Name = "Temp Celcius : ")]
        public double TempCelcius { get; set; }

        [Display(Name = "Temp Fahrenheit : ")]
        public double TempFahrenheit { get; set; }

        [Display(Name = "Humidity : ")]
        public float Humidity { get; set; }

        [Display(Name = "Pressure : ")]
        public float Pressure { get; set; }

        [Display(Name = "Sunrise : ")]
        public DateTime Sunrise { get; set; }

        [Display(Name = "Sunset : ")]
        public DateTime Sunset { get; set; }
    }
}

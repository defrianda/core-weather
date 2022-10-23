using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RESTCountries.Services;
using RESTCountries.Models;

namespace core_weather.Models
{
    public class SearchByCity
    {
        public string CountryName { get; set; }

        [Required(ErrorMessage = "City name is required!")]
        [Display(Name = "City Name : ")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Length must be between 2 and 30 characters")]
        public string CityName { get; set; }
    }
}

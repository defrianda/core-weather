using core_weather.OpenWeatherModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_weather.Repositories
{
    public interface ICountry
    {
        CountryResponse GetCountry(string country);
    }
}

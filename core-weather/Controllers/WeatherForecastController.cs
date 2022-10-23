using core_weather.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_weather.Repositories;
using core_weather.OpenWeatherModel;
using System.Globalization;

namespace core_weather.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IWeatherForecastRepo _IWeatherForecastRepo;

        public WeatherForecastController(IWeatherForecastRepo weatherForecastRepo)
        {
            _IWeatherForecastRepo = weatherForecastRepo;
        }

        private static DateTime ConvertUnixToDateTime(double unixTime)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return dt.AddSeconds(unixTime).ToLocalTime();
        }

        public static double ConvertToFahrenheit(double celsius)
        {
            double temperature;
            temperature = (double)Math.Round(((9.0 / 5.0) * celsius) + 32, 2);
            return temperature;
        }
        public static double ConvertToCelcius(double fahrenheit)
        {
            double temperature;
            temperature = (double)Math.Round((fahrenheit - 32) * 5 / 9, 2);
            return temperature;
        }

        [HttpGet]
        public IActionResult SearchByCity()
        {
            var viewModel = new SearchByCity();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SearchByCity(SearchByCity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "WeatherForecast", new { city = model.CityName });
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult City(string city)
        {
            WeatherResponse weatherResponse = _IWeatherForecastRepo.GetForecast(city);
            City viewModel = new City();
            if (weatherResponse != null)
            {
                DateTime Sunrise = ConvertUnixToDateTime(weatherResponse.Sys.Sunrise);
                DateTime Sunset = ConvertUnixToDateTime(weatherResponse.Sys.Sunset);
                DateTime DateTime = ConvertUnixToDateTime(weatherResponse.Dt);

                //• Dew Point -> this is for API one call, so I can not afford this requirement because my account is free account

                viewModel.Name = weatherResponse.Name;
                viewModel.Longitude = weatherResponse.Coord.Lon;
                viewModel.Latitude = weatherResponse.Coord.Lat;
                viewModel.DateTime = DateTime;
                viewModel.Visibility = weatherResponse.Visibility;
                viewModel.SkyConditions = weatherResponse.Weather[0].Description;
                viewModel.TempFahrenheit = (double)Math.Round(weatherResponse.Main.Temp, 2);
                viewModel.TempCelcius = ConvertToCelcius((double)Math.Round(weatherResponse.Main.Temp, 2));
                viewModel.Humidity = weatherResponse.Main.Humidty;
                viewModel.Pressure = weatherResponse.Main.Pressure;
                viewModel.Weather = weatherResponse.Weather[0].Main;
                viewModel.Wind = weatherResponse.Wind.Speed;
                viewModel.Sunrise = Sunrise;
                viewModel.Sunset = Sunset;
            }
            return View(viewModel);
        }

    }
}

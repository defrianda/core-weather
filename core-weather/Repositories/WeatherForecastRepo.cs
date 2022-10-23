using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_weather.OpenWeatherModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace core_weather.Repositories
{
    public class WeatherForecastRepo : IWeatherForecastRepo
    {
        public WeatherResponse GetForecast(string city)
        {
            string APP_ID = Config.Config.WEATHER_API_KEY;

            var client = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={APP_ID}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                return content?.ToObject<WeatherResponse>();
            }
            else
            {
                return null;
            }
        }
    }
}

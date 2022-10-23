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
    public class Country : ICountry
    {
        public CountryResponse GetCountry(string city)
        {
            var client = new RestClient($"https://restcountries.com/v3.1/all");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                return content?.ToObject<CountryResponse>();
            }
            else
            {
                return null;
            }
        }
    }
}

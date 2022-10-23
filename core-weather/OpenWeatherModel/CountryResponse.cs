using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_weather.OpenWeatherModel
{
    public class CountryResponse
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("alpha2Code")]
        public string alpha2Code { get; set; }
    }
}

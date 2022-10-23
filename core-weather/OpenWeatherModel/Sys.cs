using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_weather.OpenWeatherModel
{
    public class Sys
    {
        public int Type { get; set; }
        public int Id { get; set; }
        public string Country { get; set; }
        public float Sunrise { get; set; }
        public float Sunset { get; set; }
        private static DateTime ConvertUnixToDateTime(double unixTime)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return dt.AddSeconds(unixTime).ToLocalTime();
        }
    }
}

using core_weather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_weather.Helper
{
    public class CountriesHelper
    {
        public static List<Countries> GetAll()
        {
            return new List<Countries>
            {
                new Countries() {id="AF",name="Afghanistan"},
                new Countries() {id="AU",name="Australia"},
                new Countries() {id="ID",name="Indonesia"}
            };
        }
    }
}

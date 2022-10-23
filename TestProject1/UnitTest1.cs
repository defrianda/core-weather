using core_weather.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFahrenheitToCelsius()
        {
            double tempF = 88.07;
            double tempC_Actual;
            double tempC_Expected = 31.15;

            tempC_Actual = WeatherForecastController.ConvertToCelcius(tempF);

            Assert.AreEqual(tempC_Expected, tempC_Actual, 0.001, "Temperature conversion are not correct!");

        }
    }
}

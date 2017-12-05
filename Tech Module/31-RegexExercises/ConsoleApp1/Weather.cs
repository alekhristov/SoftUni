using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Weather
{
    class Weather
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<city>[A-Z]{2})(?<temp>\d*\.\d*)(?<weatherType>[a-zA-Z]+)\|";
            var input = Console.ReadLine();
            var cityTemp = new Dictionary<string, double>();
            var cityForecast = new Dictionary<string, string>();

            while (input != "end")
            {
                var matchedWeather = Regex.Matches(input, pattern);

                foreach (Match weather in matchedWeather)
                {
                    var city = weather.Groups["city"].Value;
                    var temp = weather.Groups["temp"].Value;
                    var weatherType = weather.Groups["weatherType"].Value;

                    if (!cityTemp.ContainsKey(city))
                    {
                        cityTemp[city] = 0;
                        cityForecast[city] = "";
                    }
                    cityTemp[city] = double.Parse(temp);
                    cityForecast[city] = weatherType;

                }

                input = Console.ReadLine();
            }

            foreach (var kvp in cityTemp.OrderBy(t => t.Value))
            {
                var city = kvp.Key;
                var averageTemp = kvp.Value;
                var weatherForecast = cityForecast[kvp.Key];
                Console.WriteLine($"{city} => {averageTemp:f2} => {weatherForecast}");
            }

        }
    }
}

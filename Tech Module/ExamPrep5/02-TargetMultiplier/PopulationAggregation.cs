using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Population_Aggregation
{
    class PopulationAggregation
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> countries = new SortedDictionary<string, long>();
            SortedDictionary<string, long> cities = new SortedDictionary<string, long>();

            int i = 1;
            while (true)
            {
                Debug.WriteLine(i);
                var cmd = Console.ReadLine();
                if (cmd == "stop")
                    break;

                char[] separators = new char[] { '@', '#', '$', '&', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };

                //string text = String.Join("", cmd.Split(separators));
                string[] words = cmd.Split('\\');

                string country = "";
                string city = "";
                string firstWord = words[0];
                if (char.IsUpper(firstWord[0]))
                {
                    country = String.Join("", words[0].Split(separators));
                    city = String.Join("", words[1].Split(separators));
                }
                else
                {
                    country = String.Join("", words[1].Split(separators));
                    city = String.Join("", words[0].Split(separators));
                }
                long population = Convert.ToInt64(words[2]);


                if (!countries.ContainsKey(country))
                {
                    countries[country] = 1;
                }
                else
                {
                    countries[country]++;
                }

                if (!cities.ContainsKey(city))
                {
                    cities[city] = population;
                }

            }

            foreach (var countryName in countries)
                Console.WriteLine(string.Join(" -> ", countryName.Key, countryName.Value));


            var index = 0;
            foreach (var cityName in cities.OrderByDescending(key => key.Value))
            {
                if (index < 3)
                {
                    Console.WriteLine(string.Join(" -> ", cityName.Key, cityName.Value));
                    index++;
                }
            }

        }
    }
}
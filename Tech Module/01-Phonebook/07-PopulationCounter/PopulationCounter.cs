using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var countryPopulation = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                var array = input.Split('|');
                var city = array[0];
                var country = array[1];
                var population = long.Parse(array[2]);


                if (!countryPopulation.ContainsKey(country))
                {
                    countryPopulation[country] = new Dictionary<string, long>();
                }
                if (!countryPopulation[country].ContainsKey(city))
                {
                    countryPopulation[country][city] = 0;
                }
                countryPopulation[country][city] += population;

                input = Console.ReadLine();
            }

            foreach (var country in countryPopulation.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var kvp in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}

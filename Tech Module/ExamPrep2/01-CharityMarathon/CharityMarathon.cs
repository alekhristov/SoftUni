using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            var marathonLength = long.Parse(Console.ReadLine());
            var numberOfRunners = long.Parse(Console.ReadLine());
            var averageNumberOfLaps = long.Parse(Console.ReadLine());
            var lapLength = long.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());
            long runnersForTheDay = 0;
            decimal totalMetres = 0;

            for (long i = 0; i < marathonLength; i++)
            {
                if (trackCapacity < numberOfRunners)
                {
                    runnersForTheDay = trackCapacity;
                    numberOfRunners -= trackCapacity;
                }
                else
                {
                    runnersForTheDay = numberOfRunners;
                    numberOfRunners = 0;
                }

                totalMetres += runnersForTheDay * averageNumberOfLaps * lapLength;
            }


            var totalKm = totalMetres / 1000;
            var moneyRaised = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EnduranceRally
{
    class EnduranceRally
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine().Split();
            var zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var checkpointIndex = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dict = new Dictionary<string, double>();
            var indexReached = 0;

            foreach (var driver in drivers)
            {
                var startingFuel = driver[0];

                if (!dict.ContainsKey(driver))
                {
                    dict[driver] = startingFuel;
                }

                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpointIndex.Contains(i))
                    {
                        dict[driver] += zones[i];

                        if (dict[driver] <= 0)
                        {
                            indexReached = i;
                            break;
                        }
                    }
                    else
                    {
                        dict[driver] -= zones[i];

                        if (dict[driver] <= 0)
                        {
                            indexReached = i;
                            break;
                        }
                    }
                }

                if (dict[driver] > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {dict[driver]:f2}");
                }
                else
                {
                    Console.WriteLine($"{driver} - reached {indexReached}");
                }
            }
        }

    }

}

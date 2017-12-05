using System;
using System.Linq;

namespace _03_HornetAssault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            long hornetsPower = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornetsPower > beehives[i])
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else
                {
                    beehives[i] -= hornetsPower;

                    if (beehives[i] == 0)
                    {
                        beehives.RemoveAt(i);
                        i--;
                    }
                    hornetsPower -= hornets[0];
                    hornets.RemoveAt(0);

                    if (hornets.Count == 0)
                    {
                        break;
                    }
                }
            }

            if (beehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else if (hornets.Count > 0)
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

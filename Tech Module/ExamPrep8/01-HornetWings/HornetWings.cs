using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine()) / 1000;
            long endurance = long.Parse(Console.ReadLine());

            double distance = speed * wingFlaps;
            double totalRest = (wingFlaps / endurance) * 5;
            double timeFlying = wingFlaps / 100;
            double totalTime = totalRest + timeFlying;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}

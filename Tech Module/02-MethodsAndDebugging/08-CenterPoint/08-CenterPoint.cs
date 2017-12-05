using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            FindDistanceToTheCenter(x1, y1, x2, y2);

        }

        private static void FindDistanceToTheCenter(double x1, double y1, double x2, double y2)
        {
            double distancePoint1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double distancePoint2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (distancePoint1 <= distancePoint2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }

            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}

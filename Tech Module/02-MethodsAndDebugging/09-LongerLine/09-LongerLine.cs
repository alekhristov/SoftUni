using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());


            FindLineDistance(x1, y1, x2, y2, x3, y3, x4, y4);

        }

        private static void FindLineDistance(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double distance1 = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double distance2 = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));

            if (distance1 >= distance2)
            {
                double distancePoint1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
                double distancePoint2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
                double distancePoint3 = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
                double distancePoint4 = Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));

                if (distancePoint1 <= distancePoint2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                double distancePoint1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
                double distancePoint2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
                double distancePoint3 = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
                double distancePoint4 = Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));

                if (distancePoint3 <= distancePoint4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }

            }
        }
    }
}

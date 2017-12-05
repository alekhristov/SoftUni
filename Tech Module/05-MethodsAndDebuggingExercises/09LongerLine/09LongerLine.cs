using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09LongerLine
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

			CheckWhichLineIsLonger(x1, y1, x2, y2, x3, y3, x4, y4);
		}

		private static void CheckWhichLineIsLonger(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
		{
			double distance1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
			double distance2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));

			if (distance1 >= distance2)
			{
				double point1 = Math.Sqrt((x1 * x1) + (y1 * y1));
				double point2 = Math.Sqrt((x2 * x2) + (y2 * y2));

				if (point1 <= point2)
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
				double point3 = Math.Sqrt((x3 * x3) + (y3 * y3));
				double point4 = Math.Sqrt((x4 * x4) + (y4 * y4));

				if (point3 <= point4)
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

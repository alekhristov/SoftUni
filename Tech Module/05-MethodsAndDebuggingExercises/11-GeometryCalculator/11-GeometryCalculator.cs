using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GeometryCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			string figure = Console.ReadLine();

			Console.WriteLine(CalculateTheAreaOfTheFigure(figure));
		}

		private static double CalculateTheAreaOfTheFigure(string figure)
		{
			if (figure == "triangle")
			{
				double side = double.Parse(Console.ReadLine());
				double height = double.Parse(Console.ReadLine());
				return TriangleArea(side, height);
			}
			else if (figure == "square")
			{
				double side = double.Parse(Console.ReadLine());
				return SquareArea(side);
			}
			else if (figure == "rectangle")
			{
				double width = double.Parse(Console.ReadLine());
				double height = double.Parse(Console.ReadLine());
				return RectangleArea(width, height);
			}
			else if (figure == "circle")
			{
				double radius = double.Parse(Console.ReadLine());
				return CircleArea(radius);
			}
			return 0;
		}

		private static double CircleArea(double radius)
		{
			return Math.PI * radius * radius;
		}

		private static double RectangleArea(double width, double height)
		{
			return width * height;
		}

		private static double SquareArea(double side)
		{
			return side * side;
		}

		private static double TriangleArea(double side, double height)
		{
			return side * height / 2;
		}
	}
}

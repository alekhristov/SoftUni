using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ClosestTwoPoints
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var points = new List<Point>();

			for (int i = 0; i < n; i++)
			{
				var currentPointParse = Console.ReadLine()
					.Split()
					.Select(double.Parse)
					.ToArray();

				var currentPoint = new Point
				{
					X = currentPointParse[0],
					Y = currentPointParse[1]
				};

				points.Add(currentPoint);

			}

			var minDistanceSoFar = double.MaxValue;
			Point firstPointMin = null;
			Point secondPointMin = null;

			for (int first = 0; first < points.Count - 1; first++)
			{
				for (int second = first + 1; second < points.Count; second++)
				{
					var firstPoint = points[first];
					var secondPoint = points[second];

					var currentDistance = CalculateDistance(firstPoint, secondPoint);

					if (currentDistance < minDistanceSoFar)
					{
						minDistanceSoFar = currentDistance;
						firstPointMin = firstPoint;
						secondPointMin = secondPoint;
					}
				}
			}

			Console.WriteLine(minDistanceSoFar);
			Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y}");
			Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y}");
		}
		public static double CalculateDistance(Point firstPoint, Point secondPoint)
		{
			var diffX = firstPoint.X - secondPoint.X;
			var diffY = firstPoint.Y - secondPoint.Y;

			var powX = Math.Pow(diffX, 2);
			var powY = Math.Pow(diffY, 2);

			return Math.Sqrt(powX + powY);
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Point
{
	public double X { get; set; }

	public double Y { get; set; }
}
namespace _04_DistanceBetweenTwoPoints
{
	
	class DistanceBetweenTwoPoints
	{
		static void Main(string[] args)
		{
			var firstPointParts = Console.ReadLine().Split().Select(double.Parse).ToArray();

			var firstPoint = new Point
			{
				X = firstPointParts[0],
				Y = firstPointParts[1]
			};

			var secondPointParse = Console.ReadLine().Split().Select(double.Parse).ToArray();

			var secondPoint = new Point
			{
				X = secondPointParse[0],
				Y = secondPointParse[1]
			};

			var result = CalculateDistance(firstPoint, secondPoint);

			Console.WriteLine($"{result:f3}");
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

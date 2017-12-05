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
            string figureType = Console.ReadLine().ToLower();

            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double triangleArea = CalculateTriangleArea(side, height);
                Console.WriteLine($"{triangleArea:f2}");
            }

            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());

                double squareSide = CalculateSquareArea(side);
                Console.WriteLine($"{squareSide:f2}");
            }

            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double rectangleArea = CalculateRectangleArea(width, height);
                Console.WriteLine($"{rectangleArea:f2}");
            }

            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                double circleArea = CalculateCircleArea(radius);
                Console.WriteLine($"{circleArea:f2}");
            }
        }

        private static double CalculateCircleArea(double radius)
        {
            double circleArea = Math.PI * radius * radius;
            return circleArea;
        }

        private static double CalculateRectangleArea(double width, double height)
        {
            double rectangleArea = width * height;
            return rectangleArea;
        }

        private static double CalculateSquareArea(double side)
        {
            double squareArea = side * side;
            return squareArea;
        }

        private static double CalculateTriangleArea(double side, double height)
        {
            double triangleArea = side * (height / 2);
            return triangleArea;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SignOfIntegerNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			PrintSignOfInteger(number);
		}

		private static void PrintSignOfInteger(int number)
		{
			if (number < 0)
			{
				Console.WriteLine($"The number {number} is negative.");
			}
			else if (number == 0)
			{
				Console.WriteLine($"The number {number} is zero.");
			}
			else
			{
				Console.WriteLine($"The number {number} is positive.");
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_FastPrimeChecker
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			for (int i = 2; i <= number; i++)
			{
				bool isPrime = true;

				for (int divisor = 2; divisor <= Math.Sqrt(i); divisor++)
				{
					if (i % divisor == 0)
					{
						isPrime = false;
						break;
					}
				}
				Console.WriteLine($"{i} -> {isPrime}");
			}

		}
	}
}

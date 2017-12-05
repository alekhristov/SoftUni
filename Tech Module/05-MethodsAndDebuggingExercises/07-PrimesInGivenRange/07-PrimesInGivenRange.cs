using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrimeChecker.PrimeChecker;

namespace _07_PrimesInGivenRange
{
	class Program
	{
		static void Main(string[] args)
		{
			int start = int.Parse(Console.ReadLine());
			int end = int.Parse(Console.ReadLine());

			var primesInRange = FindPrimesInRange(start, end);
			Console.WriteLine(string.Join(", ", primesInRange));
		}

		static List<int> FindPrimesInRange(int start, int end)
		{
			var primes = new List<int>();

			for (int currentNum = start; currentNum <= end; currentNum++)
			{
				if (CheckIfNumberIsPrime(currentNum))
				{
					primes.Add(currentNum);
				}
			}
				return primes;
		}
	}
}

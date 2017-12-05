using System;

namespace PrimeChecker
{
	public class PrimeChecker
	{
		static void Main()
		{
			long num = long.Parse(Console.ReadLine());

			bool isPrime = CheckIfNumberIsPrime(num);
			Console.WriteLine(isPrime);
		}

		public static bool CheckIfNumberIsPrime(long num)
		{
			bool isPrime = true;

			if (num == 1 || num == 0)
			{
				return isPrime = false;
			}

			for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
			{

				if (num % divisor == 0)
				{
					isPrime = false;
				}
			}
			return isPrime;
		}
	}
}
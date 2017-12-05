using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MasterNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			CheckIfNumberIsPalindrome(number);
			CheckIfNumberIsDivisibleBy7(number);
			CheckIfNumberHasEvenDigits(number);
			for (int i = 7; i <= number; i++)
			{
				if (CheckIfNumberIsPalindrome(i) == true && CheckIfNumberIsDivisibleBy7(i) == true && CheckIfNumberHasEvenDigits(i) == true)
				{
					Console.WriteLine(i);
				}
			}
		}

		private static bool CheckIfNumberHasEvenDigits(int number)
		{
			bool containsEven = false;

			for (int i = 0; i <= number; i++)
			{

				while (number > 0)
				{
					int lastDigit = number % 10;
					if (lastDigit % 2 == 0)
					{
						containsEven = true;
					}
					number /= 10;
				}

			}
			return containsEven;
		}

		private static bool CheckIfNumberIsDivisibleBy7(int number)
		{
			int sum = 0;
			bool isDivisibleBy7 = false;

			for (int i = 0; i <= number; i++)
			{

				while (number > 0)
				{

					int lastDigit = number % 10;
					sum += lastDigit;
					number /= 10;
				}

				if (sum % 7 == 0)
				{
					isDivisibleBy7 = true;
				}
			}
			return isDivisibleBy7;
		}

		private static bool CheckIfNumberIsPalindrome(int number)
		{
			bool isPallindrome = false;
			string numString = number.ToString();
			int equalPairs = 0;

			for (int i = 0; i < numString.Length / 2; i++)
			{
				if (numString[i] == numString[numString.Length - 1 - i])
				{
					equalPairs++;
				}
			}

			if (equalPairs == numString.Length / 2)
			{
				isPallindrome = true;
			}
			else
			{
				isPallindrome = false;
			}
			return isPallindrome;


		}
	}
}

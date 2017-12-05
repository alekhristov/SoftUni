using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FibonacciNumbers
{
	class FibonacciNumbers
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			FibonacciNum(number);
		}

		private static void FibonacciNum(int number)
		{
			int firstNum = 1;
			int secondNum = 1;
			int fibNextNum = 1;

			for (int i = 3; i <= number+1; i++)
			{
			    fibNextNum = firstNum + secondNum;
				secondNum = firstNum;
				firstNum = fibNextNum;

			}
			    Console.WriteLine(fibNextNum);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13_Factorial
{
	class Factorial
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			BigInteger factorial = 1;

			for (int i = 2; i <= n; i++)
			{
				factorial *= i;
			}
			Console.WriteLine(factorial);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RotateAndArray
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] numbers = Console.ReadLine().Split();
			int k = int.Parse(Console.ReadLine());

			for (int i = 0; i < k; i++)
			{

				for (int j = 0; j < numbers.Length; j++)
				{

					if (j < numbers.Length - 1)
					{
						numbers[j] = numbers[j - 1];
					}

					if (numbers[j] == numbers[numbers.Length-1])
					{
						numbers[0] = numbers[numbers.Length - 1];
					}
				}
			}

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int n = int.Parse(Console.ReadLine());
			int counter = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				for (int k = i + 1; k < numbers.Length; k++)
				{
					if (Math.Abs(numbers[k] - numbers[i]) == n && i < k)
					{
						//Console.WriteLine(numbers[i] + " " + numbers[k]);
						counter++;
					}
				}
			}//end of for

			Console.WriteLine(counter);

		}
	}
}
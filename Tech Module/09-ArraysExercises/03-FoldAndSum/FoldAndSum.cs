using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FoldAndSum
{
	class FoldAndSum
	{
		static void Main(string[] args)
		{
			string[] inputNumbers = Console.ReadLine().Split(' ');
			int[] numbers = inputNumbers.Select(n => int.Parse(n)).ToArray();
			if (numbers.Length % 4 != 0)
			{
				throw new Exception();
			}

			int k = numbers.Length / 4;
			int[] firstRow = new int[numbers.Length / 2];
			int[] secondRow = new int[numbers.Length / 2];
			int[] resultRow = new int[numbers.Length / 2];


			for (int i = k - 1; i >= 0; --i)
			{
				firstRow[k - i - 1] = numbers[i];
			}

			for (int i = k * 4 - 1; i >= k * 3; --i)
			{
				firstRow[k + (k * 4 - i - 1)] = numbers[i];
			}

			for (int i = k; i < 3 * k; ++i)
			{
				secondRow[i - k] = numbers[i];
			}

			for (int i = 0; i < k * 2; ++i)
			{
				resultRow[i] = firstRow[i] + secondRow[i];
			}

			Console.WriteLine(string.Join(" ", resultRow));
		}
	}
}

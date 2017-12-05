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
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int k = numbers.Length / 4;
			int[] firstRow = new int[2 * k];
			int[] secondRow = new int[2 * k];
			int[] sum = new int[2 * k];
			int firstRowIndex = k * 2 - 1;

			for (int i = 0; i < 4 * k; i++)
			{
				if (i < k)
				{
					firstRow[firstRow.Length - k - i - 1] += numbers[i];
				}
				else if (i >= k && i < 3 * k)
				{
					secondRow[i - k] += numbers[i];
				}
				else if (i >= 3 * k)
				{
					firstRow[firstRowIndex] += numbers[i];
					firstRowIndex--;

				}

			}
			for (int i = 0; i < 2 * k; i++)
			{
				sum[i] = firstRow[i] + secondRow[i];
			}
			Console.WriteLine(string.Join(" ", sum));
		}
	}
}

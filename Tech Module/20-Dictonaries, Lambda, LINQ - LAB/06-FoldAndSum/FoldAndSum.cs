using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_FoldAndSum
{
	class FoldAndSum
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int k = numbers.Length / 4;

			var leftFirstRow = numbers
				.Take(k)
				.Reverse()
				.ToArray();

			var rightFirstRow = numbers
				.Reverse()
				.Take(k)
				.ToArray();

			var secondRow = numbers
				.Skip(k)
				.Take(2 * k)
				.ToArray();

			var firstRow = leftFirstRow.Concat(rightFirstRow).ToArray();

			var result = firstRow
				.Zip(secondRow,
				(x, y) => x + y)
				.ToArray();

			Console.WriteLine(string.Join(" ", result));
		}
	}
}

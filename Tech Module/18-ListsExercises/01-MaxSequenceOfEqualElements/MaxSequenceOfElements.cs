using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	class MaxSequenceOfEqualElements
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			int count = 1;
			int maxCount = 1;
			int index = 0;

			for (int i = 0; i < numbers.Count - 1; i++)
			{
				if (numbers[i] == numbers[i + 1])
				{
					count++;
				}
				else
				{
					count = 1;
				}
				if (count > maxCount)
				{
					maxCount = count;
					index = i;
				}
			}
			for (int i = 0; i < maxCount; i++)
			{
				Console.Write(numbers[index] + " ");
			}
			Console.WriteLine();
		}
	}
}
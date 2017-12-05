using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MostFrequentNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int counter = 1;
			int maxCount = counter;
			int mostFrequentNumber = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] == mostFrequentNumber)
				{
					continue;
				}
				for (int j = i + 1; j < numbers.Length; j++)
				{
					if (numbers[i] == numbers[j])
					{
						counter++;

						if (counter > maxCount)
						{
							maxCount = counter;
							mostFrequentNumber = numbers[i];
						}
					}
				}
				counter = 1;
			}
				Console.WriteLine(mostFrequentNumber);
		}
	}
}

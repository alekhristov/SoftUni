using System;
using System.Linq;
using System.IO;

namespace _01_MostFrequentNumber
{
	class MostFrequentNumber
	{
		static void Main()
		{
			string filePath = "../../input.txt";

			int[] numbers = File.ReadAllText(filePath)
				.Split()
				.Select(int.Parse)
				.ToArray();
			int counter = 1;
			int maxCount = counter;
			int mostFrequentNumber = 0;


			for (int i = 0; i < numbers.Length - 1; i++)
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
			if (maxCount > 1)
			{
				File.WriteAllText("output.txt", Convert.ToString(mostFrequentNumber));
			}
			else
			{
				File.WriteAllText("output.txt", Convert.ToString(numbers[0]));
			}
		}
	}
}

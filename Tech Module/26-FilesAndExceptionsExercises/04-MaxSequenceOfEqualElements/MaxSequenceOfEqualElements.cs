using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04_MaxSequenceOfEqualElements
{
	class MaxSequenceOfEqualElements
	{
		static void Main(string[] args)
		{
			var path = "../../input.txt";
			int[] numbers = File.ReadAllText(path)
				.Split()
				.Select(int.Parse)
				.ToArray();
			int counter = 1;
			int maxCounter = counter;
			string sequence = string.Empty;
			string maxSequence = string.Empty;

			for (int i = 0; i < numbers.Length - 1; i++)
			{
				if (numbers[i] == numbers[i + 1])
				{
					counter++;
					if (counter == 2)
					{
						if (counter >= maxCounter)
						{
							sequence += numbers[i] + " ";
							sequence += numbers[i + 1] + " ";
						}
					}
					if (counter > 2)
					{
						if (counter >= maxCounter)
						{
							sequence += numbers[i] + " ";
						}
					}
					if (counter > maxCounter)
					{
						maxCounter = counter;
						maxSequence = sequence;
					}
				}
				else
				{
					counter = 1;
					sequence = string.Empty;
				}

			}
			File.WriteAllText("output.txt", maxSequence);
		}
	}
}

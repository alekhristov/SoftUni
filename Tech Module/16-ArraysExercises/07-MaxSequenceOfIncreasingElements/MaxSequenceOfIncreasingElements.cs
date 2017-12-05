using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MaxSequenceOfEqualElements
{
	class MaxSequenceOfEqualElements
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int counter = 1;
			int maxCounter = counter;
			string sequence = string.Empty;
			string maxSequence = string.Empty;

			for (int i = 0; i < numbers.Length - 1; i++)
			{
				if (numbers[i] + 1 == numbers[i + 1])
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
							sequence += numbers[i+1] + " ";
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
			Console.WriteLine(maxSequence);
		}
	}
}

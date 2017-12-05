using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercises
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] array1 = Console.ReadLine().Split();
			string[] array2 = Console.ReadLine().Split();

			int largestCommonEnd = FindLargestCommonEnd(array1, array2);
			Console.WriteLine(largestCommonEnd);
		}

		private static int FindLargestCommonEnd(string[] array1, string[] array2)
		{
			int minLength = Math.Min(array1.Length, array2.Length);

			int countLeft = 0;
			int countRight = 0;

			for (int i = 0; i < minLength; i++)
			{
				if (array1[i] == array2[i])
				{
					countLeft++;
				}

				if (array1[array1.Length - 1 - i] == array2[array2.Length - 1 - i])
				{
					countRight++;
				}
			}
			if (countLeft >= countRight)
			{
				return countLeft;
			}
			else
			{
				return countRight;
			}
		}
	}
}

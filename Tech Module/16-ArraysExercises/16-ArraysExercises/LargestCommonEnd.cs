using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ArraysExercises
{
	class LargestCommonEnd
	{
		static void Main(string[] args)
		{
			string[] array1 = Console.ReadLine().Split().ToArray();
			string[] array2 = Console.ReadLine().Split().ToArray();
			int counterLeft = 0;
			int counterRight = 0;

			for (int left = 0; left < Math.Min(array1.Length, array2.Length); left++)
			{
				if (array1[left] == array2[left])
				{
					counterLeft++;
				}
			}
			for (int right = Math.Min(array1.Length, array2.Length)-1; right >= 0; right--)
			{
				if (array1[array1.Length - 1 - right] == array2[array2.Length - 1 - right])
				{
					counterRight++;
				}
			}

			Console.WriteLine(Math.Max(counterLeft, counterRight));
		}
	}
}

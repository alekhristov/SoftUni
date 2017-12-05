using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_GrabAndGo
{
	class GrabAndGo
	{
		static void Main(string[] args)
		{
			long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
			long n = long.Parse(Console.ReadLine());
			long lastPosition = 0;
			long sum = 0;

			for (int i = 1; i <= numbers.Length; i++)
			{
				if (n == numbers[i-1])
				{
					lastPosition = i;
				}
			}

			for (int k = 1; k < lastPosition; k++)
			{
				sum += numbers[k-1];
			}

			if (lastPosition > 0)
			{
				Console.WriteLine(sum);
			}
			else
			{
				Console.WriteLine("No occurrences were found!");
			}
		}
	}
}

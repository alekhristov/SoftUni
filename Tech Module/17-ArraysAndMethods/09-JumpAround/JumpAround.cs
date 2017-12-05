using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_JumpAround
{
	class JumpAround
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int sum = 0;

			if (numbers[0] < numbers.Length)
			{
				int currentPosition = 0;

				while (true)
				{
					sum += numbers[currentPosition];

					if (numbers[currentPosition] < numbers.Length - currentPosition)
					{
					currentPosition += numbers[currentPosition];
					}
					else if (numbers[currentPosition] <= currentPosition)
					{
						currentPosition -= numbers[currentPosition];
					}
					else
					{
						Console.WriteLine(sum);
						return;
					}
				}
			}
			else
			{
				Console.WriteLine(numbers[0]);
			}
		}
	}
}

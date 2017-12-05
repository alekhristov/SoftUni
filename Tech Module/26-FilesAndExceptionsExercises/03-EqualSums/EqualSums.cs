using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03_EqualSums
{
	class EqualSums
	{
		static void Main(string[] args)
		{
			string path = "../../input.txt";
			int[] numbers = File.ReadAllText(path)
				.Split()
				.Select(int.Parse)
				.ToArray();
			int sumLeft = 0;
			int sumRight = 0;
			int counter = 0;
			int index = 0;

			if (numbers.Length > 1)
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					for (int left = 0; left < i; left++)
					{
						sumLeft += numbers[left];
					}
					for (int right = numbers.Length - 1; right > i; right--)
					{
						sumRight += numbers[right];
					}
					if (sumLeft == sumRight)
					{
						counter++;
						index = i;
						break;
					}

					sumLeft = 0;
					sumRight = 0;
				}
				if (counter > 0)
				{
					File.WriteAllText("output.txt", Convert.ToString(index));
				}
				else
				{
					File.WriteAllText("output.txt", "no");
				}
			}
			else if (numbers.Length == 1)
			{
				File.WriteAllText("output.txt", "0");

			}
		}

	}
}

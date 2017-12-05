using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ChangeList
{
	class ChangeList
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			var oddNumbers = new List<int>();
			var evenNumbers = new List<int>();
			var command = Console.ReadLine().Split().ToArray();

			while (command[0] != "Odd" && command[0] != "Even")
			{
				int firstElement = int.Parse(command[1]);

				if (command[0] == "Delete")
				{
					while (numbers.Contains(firstElement)) numbers.Remove(firstElement);
				}
				else if (command[0] == "Insert")
				{
					int secondElement = int.Parse(command[2]);
					numbers.Insert(secondElement, firstElement);
				}
				command = Console.ReadLine().Split().ToArray();
			}

			if (command[0] == "Odd")
			{
				for (int i = 0; i < numbers.Count; i++)
				{
					if (numbers[i] % 2 == 1)
					{
						oddNumbers.Add(numbers[i]);
					}
				}
				Console.WriteLine(string.Join(" ", oddNumbers));
			}
			else if (command[0] == "Even")
			{
				for (int i = 0; i < numbers.Count; i++)
				{
					if (numbers[i] % 2 == 0)
					{
						evenNumbers.Add(numbers[i]);

					}
				}
				Console.WriteLine(string.Join(" ", evenNumbers));
			}
		}
	}
}


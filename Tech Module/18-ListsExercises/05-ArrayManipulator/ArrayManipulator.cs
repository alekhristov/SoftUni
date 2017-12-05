using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ArrayManipulator
{
	class ArrayManipulator
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
			string line = Console.ReadLine();

			while (line != "print")
			{
				var tokens = line.Split();
				var command = tokens[0];

				if (command == "add")
				{
					var index = int.Parse(tokens[1]);
					var element = int.Parse(tokens[2]);

					nums.Insert(index, element);
				}
				else if (command == "addMany")
				{
					var index = int.Parse(tokens[1]);
					var elements = new List<int>();

					for (int i = 2; i < tokens.Length; i++)
					{
						var currentItem = int.Parse(tokens[i]);
						elements.Add(currentItem);
					}

					nums.InsertRange(index, elements);
				}
				else if (command == "contains")
				{
					var element = int.Parse(tokens[1]);

					var index = nums.IndexOf(element);
					Console.WriteLine(index);
				}
				else if (command == "remove")
				{
					var index = int.Parse(tokens[1]);
					nums.RemoveAt(index);
				}
				else if (command == "shift")
				{
					var rotations = int.Parse(tokens[1]) % nums.Count;

					for (int i = 0; i < rotations; i++)
					{
						nums.Add(nums[0]);
						nums.RemoveAt(0);
					}
				}
				else if (command == "sumPairs")
				{
					var pairsSum = new List<int>();

					for (int i = 0; i < nums.Count; i += 2)
					{
						var currentElement = nums[i];
						var nextElement = 0;

						if (i < nums.Count - 1)
						{
							nextElement = nums[i + 1];
						}

						var elementsSum = currentElement + nextElement;

						pairsSum.Add(elementsSum);
					}
					nums = pairsSum;
				}
				line = Console.ReadLine();
			}
			Console.WriteLine($"[{string.Join(", ", nums)}]");
		}
	}
}

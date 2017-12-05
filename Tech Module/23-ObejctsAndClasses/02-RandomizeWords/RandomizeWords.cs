using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RandomizeWords
{
	class RandomizeWords
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split();

			var rnd = new Random();

			for (int pos1 = 0; pos1 < input.Length; pos1++)
			{
				var currentWord = input[pos1];
				var randomIndex = rnd.Next(0, input.Length);

				var tempWord = input[randomIndex];
				input[pos1] = tempWord;
				input[randomIndex] = currentWord;
			}
			foreach (var word in input)
			{
				Console.WriteLine(word);
			}
		}
	}
}

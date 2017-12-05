using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OddOccurrences
{
	class OddOccurrences
	{
		static void Main(string[] args)
		{
			var words = Console.ReadLine().ToLower().Split().ToArray();
			var dictionary = new Dictionary<string, int>();

			foreach (var word in words)
			{
				if (!dictionary.ContainsKey(word))
				{
					dictionary[word] = 0;
				}

				dictionary[word]++;
			}

			var result = new List<string>();

			foreach (var item in dictionary)
			{
				if (item.Value % 2 != 0)
				{
					result.Add(item.Key);
				}
			}
			Console.WriteLine(string.Join(", ", result));
		}
	}
}

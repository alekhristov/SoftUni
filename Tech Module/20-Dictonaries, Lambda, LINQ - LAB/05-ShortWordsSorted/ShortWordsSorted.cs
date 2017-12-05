using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ShortWordsSorted
{
	class ShortWordsSorted
	{
		static void Main(string[] args)
		{
			char[] separators = { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '};	
			string sentence = Console.ReadLine().ToLower();
			var list = sentence
				.Split(separators, StringSplitOptions.RemoveEmptyEntries)
				.Distinct()
				.Where(w => w.Length < 5)
				.OrderBy(w => w)
				.ToList();

			Console.WriteLine(string.Join(", ", list));

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02_IndexOfLetters
{
	class IndexOfLetters
	{
		static void Main(string[] args)
		{
			string path = "../../input.txt";
			string letters = File.ReadAllText(path);
			char[] array = letters.ToCharArray();

			var listResult = new List<string>();

			foreach (var letter in array)
			{
				listResult.Add($"{letter} -> {letter - 97}");
			}
			File.WriteAllLines("output.txt", listResult);
		}
	}
}

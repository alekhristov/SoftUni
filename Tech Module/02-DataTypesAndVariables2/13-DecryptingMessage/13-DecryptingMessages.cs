using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DecryptingMessage
{
	class Program
	{
		static void Main(string[] args)
		{
			int key = int.Parse(Console.ReadLine());
			int n = int.Parse(Console.ReadLine());
			string decryptedWord = string.Empty;

			for (int i = 0; i < n; i++)
			{
				char letter = char.Parse(Console.ReadLine());
				int word = (int)letter + key;

				decryptedWord += (char)word;
			}
			Console.WriteLine(decryptedWord);
		}
	}
}

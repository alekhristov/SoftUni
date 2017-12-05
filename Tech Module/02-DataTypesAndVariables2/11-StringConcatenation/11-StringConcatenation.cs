using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StringConcatenation
{
	class Program
	{
		static void Main(string[] args)
		{
			char delimeter = char.Parse(Console.ReadLine());
			string takeOddOrEven = Console.ReadLine();
			int n = int.Parse(Console.ReadLine());
			string result = string.Empty;

			for (int i = 1; i <= n; i++)
			{
				string word = Console.ReadLine();

				if (takeOddOrEven == "odd")
				{
					if (i % 2 != 0)
					{
						result += word + delimeter;
					}
				}
				else if (takeOddOrEven == "even")
				{
					if (i % 2 == 0)
					{
						result += word + delimeter;
					}
				}
			}
			result = result.Remove(result.Length - 1, 1);
			Console.WriteLine(result);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			char letter1 = Char.Parse(Console.ReadLine());
			char letter2 = Char.Parse(Console.ReadLine());
			char letter3 = Char.Parse(Console.ReadLine());

			Console.WriteLine($"{letter3}{letter2}{letter1}");
		}
	}
}

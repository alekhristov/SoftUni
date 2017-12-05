using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MaxMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			int d = Math.Max(a, b);

			GetMax(c, d);
		}

		private static void GetMax(int c, int d)
		{
			Console.WriteLine(Math.Max(c,d));
		}
	}
}

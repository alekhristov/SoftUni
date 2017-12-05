using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_DifferentIntegersSize
{
	class Program
	{
		static void Main(string[] args)
		{
			string n = Console.ReadLine();

			try
			{
				long number = long.Parse(n);
				Console.WriteLine($"{number} can fit in:");

				if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
				{
					Console.WriteLine($"* sbyte");
				}

				if (number >= byte.MinValue && number <= byte.MaxValue)
				{
					Console.WriteLine($"* byte");
				}

				if (number >= short.MinValue && number <= short.MaxValue)
				{
					Console.WriteLine($"* short");
				}

				if (number >= ushort.MinValue && number <= ushort.MaxValue)
				{
					Console.WriteLine($"* ushort");
				}

				if (number >= int.MinValue && number <= int.MaxValue)
				{
					Console.WriteLine($"* int");
				}

				if (number >= uint.MinValue && number <= uint.MaxValue)
				{
					Console.WriteLine($"* uint");
				}

				if (number >= long.MinValue && number <= long.MaxValue)
				{
					Console.WriteLine($"* long");
				}

			}
			catch (Exception)
			{
				Console.WriteLine($"{n} can't fit in any type");
			}
		}
	}
}

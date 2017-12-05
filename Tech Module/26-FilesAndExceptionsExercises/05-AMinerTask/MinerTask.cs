using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05_AMinerTask
{
	class MinerTask
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var dict = new Dictionary<string, int>();

			while (input != "stop")
			{
				var resource = input;
				var quantity = int.Parse(Console.ReadLine());

				if (!dict.ContainsKey(resource))
				{
					dict[resource] = 0;
				}

				dict[resource] += quantity;

				input = Console.ReadLine();
			}
			foreach (var item in dict)
			{
				var resourceName = item.Key;
				var resourceQuantity = item.Value;

				Console.WriteLine($"{resourceName} -> {resourceQuantity}");
			}
		}
	}
}

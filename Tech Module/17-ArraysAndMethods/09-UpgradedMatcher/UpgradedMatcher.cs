using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_InventoryMatcher
{
	class InventoryMatcher
	{
		static void Main(string[] args)
		{
			string[] products = Console.ReadLine().Split().ToArray();
			long[] quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
			decimal[] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
			List<string> listResult = new List<string>();

			string[] productOrdered = Console.ReadLine().Split().ToArray();

			while (productOrdered[0] != "done")
			{
				long quantityOrdered = long.Parse(productOrdered[1]);

				for (int i = 0; i < products.Length; i++)
				{
					if (productOrdered[0] == products[i])
					{
						if (i > quantity.Length - 1)
						{
							listResult.Add($"We do not have enough {productOrdered[0]}");
						}

						else
						{
							quantity[i] -= quantityOrdered;

							if (quantity[i] >= 0)
							{
								listResult.Add($"{productOrdered[0]} x {productOrdered[1]} costs {(quantityOrdered * price[i]):f2}");
							}
							else
							{
								listResult.Add($"We do not have enough {productOrdered[0]}");
							}
							continue;
						}
					}
				}
				productOrdered = Console.ReadLine().Split().ToArray();
			}

			foreach (var item in listResult)
			{
				Console.WriteLine(item);
			}
		}
	}
}

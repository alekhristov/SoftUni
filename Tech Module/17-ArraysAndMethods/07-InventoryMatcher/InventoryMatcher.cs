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
			int index = 0;

			string OrderedProduct = Console.ReadLine();

			while (OrderedProduct != "done")
			{
				for (int i = 0; i < products.Length; i++)
				{
					if (OrderedProduct == products[i])
					{
						index = i;
					}
				}
				int indexx = Array.IndexOf(products, OrderedProduct);
				Console.WriteLine($"{products[index]} costs: {price[index]}; Available quantity: {quantity[index]}");

				OrderedProduct = Console.ReadLine();
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SalesReport
{
	class SalesReport
	{
		static void Main(string[] args)
		{
			ReadSale();
		}

		private static object ReadSale()
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{

				var input = Console.ReadLine().Split();

				string town = input[0];
				string product = input[1];
				double price = double.Parse(input[2]);
				double quantity = double.Parse(input[3]);

				var saleObject = new Sale
				{
					Town = town,
					Product = product,
					Price = price,
					Quantity = quantity
				};
			}
		
		}
	}
}

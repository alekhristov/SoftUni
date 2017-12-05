using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_HouseBuilder
{
	class Program
	{
		static void Main(string[] args)
		{
			var price1 = long.Parse(Console.ReadLine());
			var price2 = long.Parse(Console.ReadLine());

			long priceIntMaterials = Math.Max(price1, price2) * 10;
			long priceSbyteMaterials = Math.Min(price1, price2) * 4;
			long totalPriceMaterials = priceIntMaterials + priceSbyteMaterials;

			Console.WriteLine(totalPriceMaterials);
		}
	}
}

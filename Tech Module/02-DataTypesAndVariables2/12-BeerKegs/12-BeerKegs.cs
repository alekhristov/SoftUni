using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_BeerKegs
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			double biggestKeg = double.MinValue;
			string biggestKegName = string.Empty;

			for (int i = 0; i < n; i++)
			{
				string model = Console.ReadLine();
				double radius = double.Parse(Console.ReadLine());
				double height = double.Parse(Console.ReadLine());

				double kegSize = Math.PI * radius * radius * height;

				if (kegSize > biggestKeg)
				{
					biggestKeg = kegSize;
					biggestKegName = model;
				}
			}
			Console.WriteLine(biggestKegName);
		}
	}
}

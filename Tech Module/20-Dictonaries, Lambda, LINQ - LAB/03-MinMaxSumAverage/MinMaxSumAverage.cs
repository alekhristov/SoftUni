using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MinMaxSumAverage
{
	class MinMaxSumAverage
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var list = new List<int>();

			for (int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());

				list.Add(number);
			}
			Console.WriteLine($"Sum = {list.Sum()}");
			Console.WriteLine($"Min = {list.Min()}");
			Console.WriteLine($"Max = {list.Max()}");
			Console.WriteLine($"Average = {list.Average()}");
		}
	}
}

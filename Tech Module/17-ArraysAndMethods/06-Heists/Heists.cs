using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Heists
{
	class Heists
	{
		static void Main(string[] args)
		{
			int[] prices = Console.ReadLine().Split().Select(int.Parse).ToArray();
			string[] array = Console.ReadLine().Split().ToArray();
			int jewelsCount = 0;
			int goldCount = 0;
			long totalProfit = 0;
			long totalExpenses = 0;

			while (array[0] != "Jail" && array[1] != "Time")
			{
				long expenses = long.Parse(array[1]);
				for (int i = 0; i < array[0].Length; i++)
				{
					string newArray = string.Join(" ", array[0]);
					if (newArray[i] == '%')
					{
						jewelsCount++;
					}
					else if (newArray[i] == '$')
					{
						goldCount++;
					}
				}
				totalExpenses += expenses;
				array = Console.ReadLine().Split().ToArray();
			}
			totalProfit += jewelsCount * prices[0] + goldCount * prices[1];

			if (totalProfit >= totalExpenses)
			{
				Console.WriteLine($"Heists will continue. Total earnings: {totalProfit - totalExpenses}.");
			}
			else
			{
				Console.WriteLine($"Have to find another job. Lost: {totalExpenses - totalProfit}.");
			}
		}
	}
}

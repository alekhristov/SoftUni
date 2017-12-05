using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SearchForANumber
{
	class SearchForANumber
	{
		static void Main(string[] args)
		{
			var list = Console.ReadLine().Split().Select(int.Parse).ToList();
			var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var newList = new List<int>();
			int counter = 0;


			for (int i = 0; i < array[0]; i++)
			{
				newList.Add(list[i]);
			}

			while (counter < array[1])
			{
				newList.RemoveAt(0);
				counter++;
			}
			if (newList.Contains(array[2]))
			{
				Console.WriteLine("YES!");
			}
			else
			{
				Console.WriteLine("NO!");
			}

		}
	}
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PizzaIngredients
{
	class PizzaIngredients
	{
		static void Main(string[] args)
		{
			string[] ingredients = Console.ReadLine().Split().ToArray();
			int length = int.Parse(Console.ReadLine());
			int counter = 0;
			List<string> l = new List<string>();


			for (int i = 0; i < ingredients.Length; i++)
			{
				if (ingredients[i].Length == length)
				{
					Console.WriteLine($"Adding {ingredients[i]}.");
					l.Add(ingredients[i]);
					counter++;

					if (counter == 10)
					{
						break;
					}
				}

			}
			Console.WriteLine($"Made pizza with total of {counter} ingredients.");
			Console.Write("The ingredients are: ");
			Console.WriteLine(string.Join(", ", l)+".");

		}
	}
}

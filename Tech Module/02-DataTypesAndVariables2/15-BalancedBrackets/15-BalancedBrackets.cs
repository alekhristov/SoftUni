using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_BalancedBrackets
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int counterOpener = 0;
			int counterCloser = 0;

			for (int i = 0; i < n; i++)
			{
				string str = Console.ReadLine();

				if (str == "(")
				{
					counterOpener++;
				}
				else if (str == ")")
				{
					counterCloser++;
				}
			}
			if (counterOpener == counterCloser)
			{
				Console.WriteLine("BALANCED");
			}
			else
			{
				Console.WriteLine("UNBALANCED");
			}
		}
	}
}

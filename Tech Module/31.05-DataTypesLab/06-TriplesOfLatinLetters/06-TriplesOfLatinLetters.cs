using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TriplesOfLatinLetters
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (char first = 'a'; first <= 'a'+n-1; first++)
			{
				for (char second = 'a'; second <= 'a'+n-1; second++)
				{
					for (char third = 'a'; third <= 'a'+n-1; third++)
					{
						Console.WriteLine($"{first}{second}{third}");
					}
				}
			}
		}
	}
}

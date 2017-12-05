using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SieveOfEratosthenes
{
	class SieveOfErathoshenes
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			bool[] primes = new bool[n + 1];

			for (int i = 0; i <= n; i++)
			{
				primes[i] = true;
			}

			primes[0] = primes[1] = false;

			for (int i = 2; i <= n; i++)
			{
				if (primes[i] == true)
				{
					Console.WriteLine(i);

					for (int j = 2; j <= n; j++)
					{
						if (j * i <= n && j * i >= 0)
						{
							primes[j * i] = false;
						}
					}
				}

			}
		}
	}
}

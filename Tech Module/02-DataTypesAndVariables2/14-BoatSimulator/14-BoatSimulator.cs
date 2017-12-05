using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_BoatSimulator
{
	class Program
	{
		static void Main(string[] args)
		{
			char firstBoat = char.Parse(Console.ReadLine());
			char secondBoat = char.Parse(Console.ReadLine());
			int n = int.Parse(Console.ReadLine());
			int tilesBoat1 = 0;
			int tilesBoat2 = 0;

			for (int i = 1; i <= n; i++)
			{
				string speed = Console.ReadLine();

				if (speed == "UPGRADE")
				{
					firstBoat += (char)3;
					secondBoat += (char)3;
				}
				else
				{
					if (i % 2 == 1)
					{
						tilesBoat1 += speed.Length;

						if (tilesBoat1 >= 50)
						{
							Console.WriteLine((char)firstBoat);
							break;
						}
					}
					else if (i % 2 == 0)
					{
						tilesBoat2 += speed.Length;

						if (tilesBoat2 >= 50)
						{
							Console.WriteLine((char)secondBoat);
							break;
						}
					}
				}
			}

			int winner = (Math.Max(firstBoat, secondBoat));
			Console.WriteLine((char)winner);
		}
	}
}

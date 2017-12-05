using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CubeProperties
{
	class Program
	{
		static void Main(string[] args)
		{
			double cubeSide = double.Parse(Console.ReadLine());
			string parameter = Console.ReadLine();

			Console.WriteLine($"{WhatToCalculate(cubeSide, parameter):f2}");
		}

		private static double WhatToCalculate(double cubeSide, string parameter)
		{
			if (parameter == "face")
			{
				return FindCubeFace(cubeSide, parameter);
			}
			else if (parameter == "space")
			{
				return FindCubeSpace(cubeSide, parameter);
			}
			else if (parameter == "volume")
			{
				return FindCubeVolume(cubeSide, parameter);
			}
			else if (parameter == "area")
			{
				return FindCubeArea(cubeSide, parameter);
			}
			return 0;
		}


		private static double FindCubeArea(double cubeSide, string parameter)
		{
			double cubeArea = 6 * cubeSide * cubeSide;
			return cubeArea;
		}

		private static double FindCubeVolume(double cubeSide, string parameter)
		{
			double cubeVolume = cubeSide * cubeSide * cubeSide;
			return cubeVolume;
		}

		private static double FindCubeSpace(double cubeSide, string parameter)
		{
			double cubeSpaceDiagonals = Math.Sqrt(3 * cubeSide * cubeSide);
			return cubeSpaceDiagonals;
		}

		private static double FindCubeFace(double cubeSide, string parameter)
		{
			double faceDiagonals = Math.Sqrt(2 * cubeSide * cubeSide);
			return faceDiagonals;
		}
	}
}

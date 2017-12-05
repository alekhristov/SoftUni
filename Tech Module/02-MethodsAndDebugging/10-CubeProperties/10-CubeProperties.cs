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
            string parameter = Console.ReadLine().ToLower();

            if (parameter == "face")
            {
                Console.WriteLine("{0:f2}", FindCubeFace(cubeSide));
            }

            else if (parameter == "space")
            {
                Console.WriteLine("{0:f2}", FindCubeSpace(cubeSide));
            }

            else if (parameter == "volume")
            {
                Console.WriteLine("{0:f2}", FindCubeVolume(cubeSide));
            }

            else if (parameter == "area")
            {
                Console.WriteLine("{0:f2}", FindCubeArea(cubeSide));
            }

        }

        private static double FindCubeArea(double cubeSide)
        {
            double cubeArea = 6 * Math.Pow(cubeSide, 2);
            return cubeArea;
        }

        private static double FindCubeVolume(double cubeSide)
        {
            double cubeVolume = Math.Pow(cubeSide, 3);
            return cubeVolume;
        }

        private static double FindCubeSpace(double cubeSide)
        {
            double spaceDiagonals = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
            return spaceDiagonals;
        }

        private static double FindCubeFace(double cubeSide)
        {
            double faceDiagonals = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
            return faceDiagonals;
        }
    }
}

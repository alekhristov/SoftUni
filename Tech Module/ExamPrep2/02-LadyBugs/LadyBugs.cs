using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LadyBugs
{
    class LadyBugs
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            var ladybugsIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(a => a >= 0 && a < fieldSize)
                .ToArray();

            var ladyBugs = new int[fieldSize];

            for (int i = 0; i < ladybugsIndexes.Length; i++)
            {
                var currentLadyBugs = ladybugsIndexes[i];
                ladyBugs[currentLadyBugs] = 1;
            }
            var line = Console.ReadLine();

            while (line != "end")
            {
                var command = line.Split();
                var currentIndex = int.Parse(command[0]);
                var direction = command[1];
                var flyLength = int.Parse(command[2]);

                if (currentIndex < 0 || currentIndex >= ladyBugs.Length)
                {
                    line = Console.ReadLine();
                    continue;
                }
                if (ladyBugs[currentIndex] == 0)
                {
                    line = Console.ReadLine();
                    continue;
                }

                MoveLadyBug(ladyBugs, currentIndex, flyLength, direction);

                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", ladyBugs));
        }

        private static void MoveLadyBug(int[] ladyBugs, int currentIndex, int flyLength, string direction)
        {
            ladyBugs[currentIndex] = 0;

            var leftArrayOrFoundPlace = false;

            while (!leftArrayOrFoundPlace)
            {
                switch (direction)
                {
                    case "left":
                        currentIndex -= flyLength;
                        break;
                    case "right":
                        currentIndex += flyLength;
                        break;
                }
                if (currentIndex < 0 || currentIndex >= ladyBugs.Length)
                {
                    leftArrayOrFoundPlace = true; // left array
                    continue;
                }
                if (ladyBugs[currentIndex] == 1)
                {
                    continue; // step over another ladybud, keep flying
                }
                if (ladyBugs[currentIndex] == 0)
                {
                    ladyBugs[currentIndex] = 1;
                    leftArrayOrFoundPlace = true; // found our place
                    continue;
                }
            }
        }
    }
}

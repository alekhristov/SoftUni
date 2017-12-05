using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var line = Console.ReadLine();
            var listResult = new List<int>();

            while (line != "end")
            {
                var tokens = line.Split();
                var command = tokens.First();

                if (command == "exchange")
                {
                    var index = int.Parse(tokens[1]);

                    input = ExchangeElements(input, index);
                }
                else if (command == "max" || command == "min")
                {
                    var evenOrOdd = tokens[1];

                    FindIndexOfMaxOrMinEvenOrOddElement(input, command, evenOrOdd);
                }
                else if (command == "first" || command == "last")
                {
                    var count = int.Parse(tokens[1]);
                    var evenOrOdd = tokens[2];

                    FindFirstOrLastEvenOrOddElementsCount(input, command, count, evenOrOdd);
                }

                line = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        private static void FindFirstOrLastEvenOrOddElementsCount(int[] input, string command, int count, string evenOrOdd)
        {
            if (count > input.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var parity = evenOrOdd == "even" ? 0 : 1;

            var evenOrOddElements = input
                .Where(a => a % 2 == parity)
                .ToArray();

            var firstOrLastEvenOrOddElements = new List<int>();

            if (command == "first")
            {
                firstOrLastEvenOrOddElements.AddRange(evenOrOddElements.Take(count));
            }
            else
            {
                firstOrLastEvenOrOddElements.AddRange(evenOrOddElements.Skip(evenOrOddElements.Length - count));
            }

            Console.WriteLine($"[{string.Join(", ", firstOrLastEvenOrOddElements)}]");
        }

        static void FindIndexOfMaxOrMinEvenOrOddElement(int[] input, string minOrMax, string evenOrOdd)
        {
            var parity = evenOrOdd == "even" ? 0 : 1;

            var evenOrOddElements = input
                .Where(a => a % 2 == parity)
                .ToArray();

            if (!evenOrOddElements.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            int minOrMaxElement;

            if (minOrMax == "min")
            {
                minOrMaxElement = evenOrOddElements.Min();
            }
            else
            {
                minOrMaxElement = evenOrOddElements.Max();
            }

            var index = Array.LastIndexOf(input, minOrMaxElement);
            Console.WriteLine(index);
        }

        static int[] ExchangeElements(int[] input, int index)
        {
            var isValidIndex = index >= 0 && index < input.Length;

            if (!isValidIndex)
            {
                Console.WriteLine("Invalid index");
                return input;
            }

            var leftPart = input.Take(index + 1).ToArray();
            var rightPart = input.Skip(index + 1).ToArray();

            var concatenated = rightPart.Concat(leftPart).ToArray();

            return concatenated;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ArrayModifier
{
    class ArrayModifier
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                var commands = commandLine.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = commands[0];

                if (command == "swap" || command == "multiply")
                {
                    var index1 = int.Parse(commands[1]);
                    var index2 = int.Parse(commands[2]);

                    switch (command)
                    {
                        case "swap":
                            SwapNumbers(array, index1, index2);
                            break;
                        case "multiply":
                            MultiplyNumbers(array, index1, index2);
                            break;
                        default:
                            break;
                    }
                }
                else if (command == "decrease")
                {
                    DecreaseNumbers(array);
                }

                commandLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", array));
        }

        private static void DecreaseNumbers(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]--;
            }
        }

        private static void MultiplyNumbers(long[] array, int index1, int index2)
        {
            var num1 = array[index1];
            var num2 = array[index2];
            var product = num1 * num2;

            array[index1] = product;
        }

        private static void SwapNumbers(long[] array, int index1, int index2)
        {
            var swapNum1 = array[index1];
            var swapNum2 = array[index2];

            array[index1] = swapNum2;
            array[index2] = swapNum1;
        }

    }
}

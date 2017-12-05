using System;
using System.Linq;

namespace ConsoleApplication926
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Where(x => x.Length == 2)
                .Reverse()
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                char[] charArray = numbers[i].ToCharArray();
                Array.Reverse(charArray);
                Console.Write(Convert.ToChar(Convert.ToUInt32(new string(charArray), 16)));
            }
            Console.WriteLine();
        }
    }
}
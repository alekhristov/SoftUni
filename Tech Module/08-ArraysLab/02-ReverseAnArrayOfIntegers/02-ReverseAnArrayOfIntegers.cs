using System;
using System.Numerics;
using System.Linq;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        var numbers = new int[num];

        for (int i = 0; i < num; i++)
        {
           var currentNumber = int.Parse(Console.ReadLine());
            numbers[i] = currentNumber;
        }

        for (int i = numbers.Length-1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}


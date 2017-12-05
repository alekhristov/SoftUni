using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger num = BigInteger.Parse(Console.ReadLine());

        Console.WriteLine(Factorial(num));
    }

    private static BigInteger Factorial(BigInteger num)
    {
        BigInteger factorial = 1;

        for (int i = (int)num; i >= 2; i--)
        {
            factorial *= num;
            num--;
        }
        return factorial;
    }
}


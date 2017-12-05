using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger num = BigInteger.Parse(Console.ReadLine());

        Factorial(num);
        Console.WriteLine(TrailingZeroes(Factorial(num)));
    }

    private static BigInteger TrailingZeroes(BigInteger factorial)
    {
        int counter = 0;
        while (factorial % 10 == 0)
        {
            if (factorial % 10 == 0)
            {
                counter++;
            }
            factorial /= 10;

        }
        return counter;

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


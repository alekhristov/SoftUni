using System;

class Program
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());

        bool isPrime = CheckIfNumberIsPrime(num);
        Console.WriteLine(isPrime);
    }

    private static bool CheckIfNumberIsPrime(long num)
    {
        bool isPrime = true;

        if (num == 1 || num == 0)
        {
            return isPrime = false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {

            if (num % i == 0)
            {
                isPrime = false;
            }
        }
        return isPrime;
    }
}


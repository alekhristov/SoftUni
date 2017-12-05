using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        var primesInRange = FindPrimesInRange(startNum, endNum);

        Console.WriteLine(string.Join(", ", primesInRange));
    }
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        var primes = new List<int>();

        for (int currentNum = startNum; currentNum <= endNum; currentNum++)
        {
            if (CheckIfNumberIsPrime(currentNum))
            {
                primes.Add(currentNum);
            }
        }
        return primes; 
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


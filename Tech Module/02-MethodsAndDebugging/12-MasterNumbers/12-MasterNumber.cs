using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 7; i <= num; i++)
        {
            if (IsPallindrome(i) == true && SumOfDigits(i) == true && ContainsEvenDigit(i) == true)
            {
                Console.WriteLine(i);
            }
        }
    }

    private static bool IsPallindrome(int number)
    {
        bool isPallindrome = false;
        string numString = number.ToString();
        int equalPairs = 0;

        for (int i = 0; i < numString.Length / 2; i++)
        {
            if (numString[i] == numString[numString.Length - 1 - i])
            {
                equalPairs++;
            }
        }

        if (equalPairs == numString.Length / 2)
        {
            isPallindrome = true;
        }
        else
        {
            isPallindrome = false;
        }
        return isPallindrome;
    }

    private static bool SumOfDigits(int number)
    {
        string numString = number.ToString();
        int sumOfDigits = 0;

        for (int i = 0; i < numString.Length; i++)
        {
            sumOfDigits += number % 10;
            number /= 10;
        }

        if (sumOfDigits % 7 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static bool ContainsEvenDigit(int number)
    {
        string numString = number.ToString();

        for (int i = 0; i < numString.Length; i++)
        {
            int lastDigit = number % 10;

            if (lastDigit % 2 == 0)
            {
                return true;
            }
            number /= 10;
        }
        return false;
    }
}

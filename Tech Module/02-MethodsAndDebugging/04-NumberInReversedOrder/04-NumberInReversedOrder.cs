using System;

class Program
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());

        ReversedNum(number);
        Console.WriteLine(ReversedNum(number));
    }

    private static string ReversedNum(double number)
    {
        string numberString = number.ToString();
        string reversedNumber = string.Empty;

        for (int i = numberString.Length - 1; i >= 0; i--)
        {
            reversedNumber += numberString[i];
        }
        return reversedNumber;
    }
}


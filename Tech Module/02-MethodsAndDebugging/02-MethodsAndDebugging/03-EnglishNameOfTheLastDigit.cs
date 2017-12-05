using System;

class Program
{
    static void Main()
    {
        long num = Math.Abs(long.Parse(Console.ReadLine()));

        long lastDigit = GetLastDigit(num);
        string lastDigitAsWord = LastDigitToWord(lastDigit);

        Console.WriteLine(lastDigitAsWord);
    }

    private static long GetLastDigit(long num)
    {
        long lastDigit = num % 10;
        return lastDigit;
    }

    private static string LastDigitToWord(long lastDigit)
    {
        string digitAsWord = string.Empty;

        switch (lastDigit)
        {
            case 0:
                digitAsWord = "zero";
                break;
            case 1:
                digitAsWord = "one";
                break;
            case 2:
                digitAsWord = "two";
                break;
            case 3:
                digitAsWord = "three";
                break;
            case 4:
                digitAsWord = "four";
                break;
            case 5:
                digitAsWord = "five";
                break;
            case 6:
                digitAsWord = "six";
                break;
            case 7:
                digitAsWord = "seven";
                break;
            case 8:
                digitAsWord = "eight";
                break;
            case 9:
                digitAsWord = "nine";
                break;
        }
        return digitAsWord;
    }
}


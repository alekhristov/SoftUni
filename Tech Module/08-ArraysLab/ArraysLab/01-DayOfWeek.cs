using System;

class Program
{
    static void Main()
    {
        string[] days =
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
        int index = int.Parse(Console.ReadLine());

        if (index < 1 || index > 7)
        {
            Console.WriteLine("Invalid Day!");
        }
        else
        {
        Console.WriteLine(days[index-1]);
        }
    }
}


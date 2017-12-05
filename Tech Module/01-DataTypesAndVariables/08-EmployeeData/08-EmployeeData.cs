using System;

class Program
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        sbyte age = sbyte.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        long personalIDNumber = long.Parse(Console.ReadLine());
        int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Personal ID: {personalIDNumber}");
        Console.WriteLine($"Unique Employee number: {uniqueEmployeeNumber}");
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        double supply = double.Parse(Console.ReadLine());
        double a = supply;
        double[] bottles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double capacity = double.Parse(Console.ReadLine());
        double numberOfBottles = 0;
        bool filledBottles = false;
        List<long> indexes = new List<long>();
        double littersNeeded = 0;
        if (supply % 2 != 0)
        {
            for (int i = bottles.Length - 1; i >= 0; i--)
            {
                if (bottles[i] <= capacity && supply > 0)
                {
                    if (supply < capacity - bottles[i])
                    {
                        bottles[i] += supply;
                        break;
                    }
                    supply -= (capacity - bottles[i]);
                    bottles[i] += (capacity - bottles[i]);
                }
                if (bottles[0] == capacity && supply >= 0)
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", supply);
                    filledBottles = true;
                }
            }
            if (!filledBottles)
            {
                for (int i = bottles.Length - 1; i >= 0; i--)
                {
                    if (bottles[i] < capacity)
                    {
                        numberOfBottles++;
                        littersNeeded += (capacity - bottles[i]);
                        indexes.Add(i);
                    }
                    if (i == 0)
                    {
                        Console.WriteLine("We need more water!");
                        Console.WriteLine("Bottles left: {0}", numberOfBottles);
                        string joined = string.Join<long>(", ", indexes);
                        Console.WriteLine("With indexes: " + joined);
                        Console.WriteLine("We need {0} more liters!", littersNeeded);
                    }
                }
            }
        }
        if (supply % 2 == 0 && supply == a)
        {
            for (int i = 0; i < bottles.Length; i++)
            {
                if (bottles[i] <= capacity && supply > 0)
                {
                    if (supply < capacity - bottles[i])
                    {
                        bottles[i] += supply;
                        break;
                    }
                    supply -= (capacity - bottles[i]);
                    bottles[i] += (capacity - bottles[i]);
                }                                                         // I added this under && i == bottles.Length - 1
                if (bottles[bottles.Length - 1] == capacity && supply >= 0 && i == bottles.Length - 1)
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", supply);
                    filledBottles = true;
                }
            }
            if (!filledBottles)
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    if (bottles[i] < capacity)
                    {
                        numberOfBottles++;
                        littersNeeded += (capacity - bottles[i]);
                        indexes.Add(i);
                    }
                    if (i == bottles.Length - 1)
                    {
                        Console.WriteLine("We need more water!");
                        Console.WriteLine("Bottles left: {0}", numberOfBottles);
                        string joined = string.Join<long>(", ", indexes);
                        Console.WriteLine("With indexes: " + joined);
                        Console.WriteLine("We need {0} more liters!", littersNeeded);
                    }
                }
            }
        }
    }
}
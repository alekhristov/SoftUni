using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //Първото нещо, което тествах е да ти пусна кода с вход 1 1 и то грешката си е очевидна. Пробвай.

        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        while (true)
        {
            bool foundNumbers = false;

            for (int i = 1; i < numbers.Count - 1; i++)
            {
                int previousNumber = numbers[i - 1];
                int currentNumber = numbers[i];
                int nextNumber = numbers[i + 1];

                if (i == 1 && previousNumber == currentNumber)
                {
                    numbers.RemoveAt(0);
                    foundNumbers = true;
                    break;
                }
                else if (i == numbers.Count - 2 && currentNumber == nextNumber)
                {
                    numbers.RemoveAt(numbers.Count - 1);
                    foundNumbers = true;
                    break;
                }
                else
                {
                    if (currentNumber == previousNumber + nextNumber)
                    {
                        numbers.RemoveRange(i - 1, 3);
                        numbers.Insert(i - 1, currentNumber);

                        foundNumbers = true;
                        break;
                    }
                }
            }
            if (!foundNumbers)
            {
                break;
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
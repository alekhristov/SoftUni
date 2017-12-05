using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var charArray = input[i].ToCharArray();

                string numberStr = string.Empty;
                decimal number = 0;
                var firstLetterPosition = 0;
                var secondLetterPosition = 0;

                if (charArray.Length > 3)
                {
                    for (int k = 1; k < charArray.Length - 1; k++)
                    {
                        numberStr += charArray[k];
                        number = decimal.Parse(numberStr);
                    }

                    if (char.IsUpper(charArray[0]))
                    {
                        firstLetterPosition = charArray[0] - 64;
                        result += number / firstLetterPosition;
                    }
                    else if (char.IsLower(charArray[0]))
                    {
                        firstLetterPosition = charArray[0] - 96;
                        result += number * firstLetterPosition;
                    }
                    if (char.IsUpper(charArray[charArray.Length - 1]))
                    {
                        secondLetterPosition = charArray[charArray.Length - 1] - 64;
                        result -= secondLetterPosition;
                    }
                    else if (char.IsLower(charArray[charArray.Length - 1]))
                    {
                        secondLetterPosition = charArray[charArray.Length - 1] - 96;
                        result += secondLetterPosition;
                    }
                }
                else
                {
                    number = decimal.Parse(charArray[1].ToString());

                    if (char.IsUpper(charArray[0]))
                    {
                        firstLetterPosition = charArray[0] - 64;
                        result += number / firstLetterPosition;
                    }
                    else if (char.IsLower(charArray[0]))
                    {
                        firstLetterPosition = charArray[0] - 96;
                        result += number * firstLetterPosition;
                    }
                    if (char.IsUpper(charArray[charArray.Length - 1]))
                    {
                        secondLetterPosition = charArray[charArray.Length - 1] - 64;
                        result -= secondLetterPosition;
                    }
                    else if (char.IsLower(charArray[charArray.Length - 1]))
                    {
                        secondLetterPosition = charArray[charArray.Length - 1] - 96;
                        result += secondLetterPosition;
                    }
                }
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
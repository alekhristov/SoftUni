using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OnlyLetters
{
    class OnlyLetters
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine();
            //var symbols = input.ToCharArray();

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    if (char.IsDigit(symbols[i]))
            //    {
            //        if (char.IsLetter(symbols[i + 1]))
            //        {
            //            input = input.Replace(symbols[i], symbols[i + 1]);
            //        }
            //    }
            //    else
            //    {
            //        input = input.Remove(i, 1);
            //    }
            //}
            //Console.WriteLine(input);

            var input = Console.ReadLine();
            bool letterFollows = true;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    for (int k = i+1; k < input.Length; k++)
                    {
                        if (char.IsLetter(input[k]))
                        {
                            letterFollows = true;
                            break;
                        }
                        else
                        {
                            letterFollows = false;
                        }
                    }

                    if (char.IsLetter(input[i+1]))
                    {
                        input = input.Replace(input[i], input[i + 1]);
                    }
                    else if (char.IsDigit(input[i+1]) && letterFollows == true)
                    {
                        input = input.Remove(i, 1);
                        i--;
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}





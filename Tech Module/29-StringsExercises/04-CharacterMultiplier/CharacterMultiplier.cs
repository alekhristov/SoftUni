using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var string1Arr = input[0].ToCharArray();
            var string2Arr = input[1].ToCharArray();
            var sum = 0;
            var lastIndex = 0;

            var diff = Math.Abs(string1Arr.Length - string2Arr.Length);
            var min = Math.Min(string1Arr.Length, string2Arr.Length);
            var max = Math.Max(string1Arr.Length, string2Arr.Length);


            if (string1Arr.Length == string2Arr.Length)
            {
                for (int i = 0; i < Math.Max(string1Arr.Length, string2Arr.Length); i++)
                {
                    sum += string1Arr[i] * string2Arr[i];
                }

            }
            else
            {
                for (int i = 0; i < min; i++)
                {
                    sum += string1Arr[i] * string2Arr[i];
                }

                for (int i = min; i < max; i++)
                {
                    if (string1Arr.Length > string2Arr.Length)
                    {
                        sum += string1Arr[i];
                    }
                    else
                    {
                        sum += string2Arr[i];
                    }
                }
            }

            Console.WriteLine(sum);


        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string line1 = "";
            string input = Console.ReadLine();
            if (input == "0")
            {
                line1 = input;
            }
            else
            {
                line1 = input.TrimStart('0'); ;

            }

            string line2 = Console.ReadLine();
            int multiplier = 1;
            if (line2.Length != 1)
            {
                multiplier = int.Parse(line2.TrimStart('0'));
            }
            else
            {
                multiplier = int.Parse(line2);
            }

            var sb1 = new StringBuilder(line1);
            var result = new List<int>();

            var remainer = 0;

            for (int i = sb1.Length - 1; i >= 0; i--)
            {
                int num1 = int.Parse(sb1[i].ToString());
                int num2 = multiplier;
                var productLastDigit = (num1 * num2 + remainer) % 10;

                if (i == 0)
                {
                    result.Add(num1 * num2 + remainer);
                }
                else if (num1 * num2 + remainer > 9)
                {
                    result.Add(productLastDigit);
                    remainer = (num1 * num2 + remainer) / 10;
                }
                else
                {
                    result.Add(num1 * num2 + remainer);
                    remainer = 0;
                }
            }

            result.Reverse();

            Console.WriteLine(string.Join("", result));

        }
    }
}

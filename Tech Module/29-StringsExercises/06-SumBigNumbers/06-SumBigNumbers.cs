using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine().TrimStart('0');
            string line2 = Console.ReadLine().TrimStart('0');

            var sb1 = new StringBuilder(line1);
            var sb2 = new StringBuilder(line2);
            var result = new List<int>();
            int add = 0;

            var max = Math.Max(sb1.Length, sb2.Length);
            var diff = Math.Abs(sb1.Length - sb2.Length);
            var min = Math.Min(sb1.Length, sb2.Length);

            if (diff != 0)
            {
                if (sb1.Length > sb2.Length)
                {
                    sb2.Insert(0, "0", diff);
                }
                else
                {
                    sb1.Insert(0, "0", diff);
                }
            }

            for (int i = sb1.Length - 1; i >= 0; i--)
            {
                int num1 = int.Parse(sb1[i].ToString());
                int num2 = int.Parse(sb2[i].ToString());

                if (i == 0)
                {
                    result.Add(num1 + num2 + add);
                }
                else if (num1 + num2 + add > 9)
                {
                    result.Add(num1 + num2 + add - 10);
                    add = 1;
                }
                else
                {
                    result.Add(num1 + num2 + add);
                    add = 0;
                }
            }

            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02_ConvertFromNTo10
{
    class ConvertFromNto10
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var baseN = BigInteger.Parse(input[0]);
            var baseNumber = BigInteger.Parse(input[1]);
            BigInteger multiplier = 1;
            BigInteger sum = 0;

            var result = new List<BigInteger>();

            BigInteger lastDigit = baseNumber % 10;

            while (baseNumber > 0)
            {
                lastDigit = baseNumber % 10;
                sum += lastDigit * multiplier;
                multiplier *= baseN;
                baseNumber /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}

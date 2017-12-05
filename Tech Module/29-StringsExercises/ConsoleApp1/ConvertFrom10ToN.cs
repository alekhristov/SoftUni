using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    class ConvertFrom10ToN
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var baseN = BigInteger.Parse(input[0]);
            var baseNumber = BigInteger.Parse(input[1]);

            var result = new List<BigInteger>();

            BigInteger nextNumber = baseNumber / baseN;

            while (nextNumber > 0)
            {
                nextNumber = baseNumber / baseN;
                var residual = baseNumber % baseN;
                baseNumber = nextNumber;


                result.Add(residual);
            }

            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}

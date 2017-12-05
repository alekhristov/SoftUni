using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var result = new List<int>();

            double average = input.Average();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > average)
                {
                    result.Add(input[i]);
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                result = result.OrderByDescending(a => a).ToList();

                if (result.Count > 5)
                {
                    result.RemoveRange(5, result.Count - 5);
                }

                Console.WriteLine(string.Join(" ", result));
            }

        }
    }
}

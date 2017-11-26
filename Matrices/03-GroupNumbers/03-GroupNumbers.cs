using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var sw = new Stopwatch();
            sw.Start();
            //var zero = new List<int>();
            //var one = new List<int>();
            //var two = new List<int>();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (Math.Abs(input[i]) % 3 == 0)
            //    {
            //        zero.Add(input[i]);
            //    }
            //    else if (Math.Abs(input[i]) % 3 == 1)
            //    {
            //        one.Add(input[i]);
            //    }
            //    else if (Math.Abs(input[i]) % 3 == 2)
            //    {
            //        two.Add(input[i]);
            //    }
            //}

            var zero = input.Where(n => Math.Abs(n) % 3 == 0).ToArray();
            var one = input.Where(n => Math.Abs(n) % 3 == 1).ToArray();
            var two = input.Where(n => Math.Abs(n) % 3 == 2).ToArray();

            Console.WriteLine(string.Join(" ", zero));
            Console.WriteLine(string.Join(" ", one));
            Console.WriteLine(string.Join(" ", two));
            Console.WriteLine(sw.ElapsedTicks);
        }
    }
}

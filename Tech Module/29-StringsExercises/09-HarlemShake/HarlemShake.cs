using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_HarlemShake
{
    class HarlemShake
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            StringBuilder sbInput = new StringBuilder(input);
            StringBuilder sbPattern = new StringBuilder(pattern);
            int counter = 0;


            while (true)
            {
                counter = 0;
                int index1 = input.IndexOf(pattern);
                int index2 = input.LastIndexOf(pattern);

                while (index1 != -1)
                {
                    counter++;
                    index1 = input.IndexOf(pattern, index1 + 1);
                }

                if (counter > 1)
                {
                    int index = input.IndexOf(pattern);
                    sbInput.Remove(index2, pattern.Length);
                    sbInput.Remove(index, pattern.Length);

                    Console.WriteLine("Shaked it.");
                    sbPattern.Remove(sbPattern.Length / 2, 1);
                    input = sbInput.ToString();
                    pattern = sbPattern.ToString();
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(string.Join("", sbInput.ToString()));
                    return;
                }

            }

        }
    }
}

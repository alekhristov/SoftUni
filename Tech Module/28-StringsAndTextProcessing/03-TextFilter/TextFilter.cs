using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            var banList = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var text = Console.ReadLine();

            for (int i = 0; i < banList.Length; i++)
            {
                if (text.Contains(banList[i]))
                {
                    text = text.Replace(banList[i], new string('*', banList[i].Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}

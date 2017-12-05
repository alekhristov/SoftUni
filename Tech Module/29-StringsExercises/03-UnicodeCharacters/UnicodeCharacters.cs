using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            char[] charArr = input.ToCharArray();
            string unicode = "";

            for (int i = 0; i < charArr.Length; i++)
            {
                unicode += "\\u"+((int)charArr[i]).ToString("X4");
            }
            Console.WriteLine(unicode.ToLower());

        }
    }
}

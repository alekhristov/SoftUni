using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08_UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            var str = "znahny # grkg ()&^^^&12";
            var inp = str.ToCharArray();

            for (int i = 0; i < inp.Length; i++)
            {
                if (!char.IsLetterOrDigit(inp[i]))
                {
                    str = str.Replace(inp[i], ' ');
                }
                if (inp[i] < 110)
                {
                    str = str.Replace(inp[i], (char)(inp[i] + 13));
                }
                else
                {
                    str = str.Replace(inp[i], (char)(inp[i] - 13));
                }

            }
            str = Regex.Replace(str, @"\s+", " ");
            Console.WriteLine(str);
        }
    }
}

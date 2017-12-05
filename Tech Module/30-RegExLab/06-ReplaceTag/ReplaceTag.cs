using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_ReplaceTag
{
    class ReplaceTag
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                var replacement = @"[URL href=$1]$2[/URL]";

                string replaced = Regex.Replace(input, pattern, replacement);

                Console.WriteLine(replaced);


                input = Console.ReadLine();
            }

        }
    }
}

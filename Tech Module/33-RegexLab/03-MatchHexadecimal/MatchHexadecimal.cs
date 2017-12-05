using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_MatchHexadecimal
{
    class MatchHexadecimal
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(0x)?[0-9A-F]+\b";
            var input = Console.ReadLine();

            var matchedHexa = Regex.Matches(input, pattern)
                .Cast<Match>()
                .Select(n => n.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", matchedHexa));
        }
    }
}

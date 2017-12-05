using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(0x)?[0-9A-F]+\b";
            var hexNumbers = Console.ReadLine();

            var hexMatches = Regex.Matches(hexNumbers, pattern)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", hexMatches));
        }
    }
}

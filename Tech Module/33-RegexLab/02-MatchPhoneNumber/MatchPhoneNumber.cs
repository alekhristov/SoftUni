using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            var pattern = @"\+359([ |-])2\1\d{3}\1\d{4}\b";
            var input = Console.ReadLine();

            var matchedNumbers = Regex.Matches(input, pattern)
                .Cast<Match>()
                .Select(n => n.Value)
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedNumbers));
        }
    }
}

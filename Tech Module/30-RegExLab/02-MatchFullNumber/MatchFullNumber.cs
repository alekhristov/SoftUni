using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_MatchFullNumber
{
    class MatchFullNumber
    {
        static void Main(string[] args)
        {   
            string pattern = @"\+359(-| )2\1\b\d{3}\b\1\b\d{4,4}\b";

            var phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, pattern);

            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}

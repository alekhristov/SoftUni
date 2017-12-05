using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05_MatchNumbers
{
    class CameraView
    {
        static void Main(string[] args)
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.\d*)?($|(?=\s))";
            var input = Console.ReadLine();

            var matchedNumbers = Regex.Matches(input, pattern)
                .Cast<Match>()
                .Select(n => n.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", matchedNumbers));
        }
    }
}

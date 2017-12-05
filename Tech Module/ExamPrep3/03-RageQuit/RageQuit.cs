using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03_RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();
            var pattern = @"(?<str>\D+)(?<num>\d+)";
            var result = new StringBuilder();

            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                var str = match.Groups["str"].Value;
                var num = int.Parse(match.Groups["num"].Value);

                for (int i = 0; i < num; i++)
                {
                    result.Append(str);
                }
            }
            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result);
        }
    }
}

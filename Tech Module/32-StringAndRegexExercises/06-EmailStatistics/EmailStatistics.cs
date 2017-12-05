using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06_EmailStatistics
{
    class EmailStatistics
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dictResult = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var pattern = @"\b(?<username>[A-Za-z]{5,})@(?<domain>[a-z]{3,}\.[com|bg|org]+)\b";

                var matchedEmail = Regex.Match(input, pattern);

                var username = matchedEmail.Groups["username"].Value;
                var domain = matchedEmail.Groups["domain"].Value;

                if (matchedEmail.Success)
                {
                    if (!dictResult.ContainsKey(domain))
                    {
                        dictResult[domain] = new List<string>();
                    }
                    if (!dictResult[domain].Contains(username))
                    {
                        dictResult[domain].Add(username);
                    }
                }
            }

            dictResult = dictResult
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in dictResult)
            {
                Console.WriteLine($"{kvp.Key}:");

                foreach (var email in kvp.Value)
                {
                    Console.WriteLine($"### {email}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05_KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine().Split("<|\\".ToCharArray().ToArray());
            var start = key[0];
            var end = key[2];
            var text = Console.ReadLine();
            var result = string.Empty;

            var pattern = $@"{start}(?<word>[^{end}][A-Za-z]+?){end}";

            var match = Regex.Match(text, pattern);

            if (match.Success)
            {
                var matchedWords = Regex.Matches(text, pattern);

                foreach (Match word in matchedWords)
                {
                    var wordMatch = word.Groups["word"].Value;
                    result += wordMatch;
                }
                Console.WriteLine(result);
            }

            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}

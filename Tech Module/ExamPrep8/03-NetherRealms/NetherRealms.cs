using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            while (true)
            {
            var demonNames = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToArray();

                var numsPattern = @"(?<nums>[\+\-0-9(\.0-9)?]+)";
                var lettersPattern = @"(?<letters>[^\+\-\*\/\.\d])";
                var specialCharsPattern = @"(?<specialChars>[\*\/])";

                var result = new Dictionary<string, string>();

                foreach (var name in demonNames)
                {
                    if (name.Length > 0)
                    {
                        decimal health = 0;
                        decimal damage = 0;

                        var matchedLetters = Regex.Matches(name, lettersPattern);

                        foreach (Match letter in matchedLetters)
                        {
                            health += char.Parse(letter.Groups["letters"].Value);
                        }

                        var matchedNums = Regex.Matches(name, numsPattern);

                        foreach (Match num in matchedNums)
                        {
                            damage += decimal.Parse(num.Groups["nums"].Value);
                        }

                        var matchedSpecialChars = Regex.Matches(name, specialCharsPattern);

                        foreach (Match symbol in matchedSpecialChars)
                        {
                            var specialSymbol = char.Parse(symbol.Groups["specialChars"].Value);

                            switch (specialSymbol)
                            {
                                case '*':
                                    damage *= 2m;
                                    break;
                                case '/':
                                    damage /= 2m;
                                    break;
                            }
                        }

                        if (!result.ContainsKey(name) && name != "")
                        {
                            result[name] = string.Empty;
                            result[name] = $" - {health} health, {damage:f2} damage";
                        }
                    }
                }

                foreach (var kvp in result.OrderBy(a => a.Key))
                {
                    Console.WriteLine($"{kvp.Key}{kvp.Value}");
                }
            }
        }
    }
}


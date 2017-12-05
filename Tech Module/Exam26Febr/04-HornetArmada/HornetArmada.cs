using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_HornetArmada
{
    class HornetArmada
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var pattern = @"^(?<lastActivity>\d+) = (?<legionName>[^=|-|>|:|\s]*) -> (?<soldierType>[^=|-|>|:|\s]*):(?<soldierCount>\d+)";
            var legionActivity = new Dictionary<string, long>();
            var legionSoldiers = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    var lastActivity = long.Parse(match.Groups["lastActivity"].Value);
                    var legionName = match.Groups["legionName"].Value;
                    var soldierType = match.Groups["soldierType"].Value;
                    var soldierCount = long.Parse(match.Groups["soldierCount"].Value);

                    if (!legionActivity.ContainsKey(legionName))
                    {
                        legionActivity[legionName] = 0;
                    }
                    if (!legionSoldiers.ContainsKey(legionName))
                    {
                        legionSoldiers[legionName] = new Dictionary<string, long>();
                    }
                    if (legionSoldiers.ContainsKey(legionName))
                    {
                        if (legionActivity[legionName] < lastActivity)
                        {
                            legionActivity[legionName] = lastActivity;
                        }
                        if (!legionSoldiers[legionName].ContainsKey(soldierType))
                        {
                            legionSoldiers[legionName][soldierType] = 0;
                        }
                        legionSoldiers[legionName][soldierType] += soldierCount;
                    }
                }
            }
            var line = Console.ReadLine();
            var regex = @"^(?<activity>\d+)\\(?<soldier>[^=|-|>|:|\s]*)$";

            var lineMatch = Regex.Match(line, regex);

            if (lineMatch.Success)
            {
                var activity = long.Parse(lineMatch.Groups["activity"].Value);
                var soldier = lineMatch.Groups["soldier"].Value;

                foreach (var kvp in legionActivity)
                {
                    if (kvp.Value >= activity)
                    {
                        legionSoldiers.Remove(kvp.Key);
                    }
                }

                foreach (var item in legionSoldiers.OrderByDescending(s => s.Value[soldier]))
                {
                    Console.Write($"{item.Key} -> ");

                    foreach (var kvp in item.Value.Where(s => s.Key == soldier))
                    {
                        Console.WriteLine($"{kvp.Value}");
                    }
                }

            }
            else
            {
                foreach (var kvp in legionActivity.OrderByDescending(x => x.Value))
                {
                    if (legionSoldiers[kvp.Key].ContainsKey(line))
                    {
                        Console.WriteLine($"{kvp.Value} : {kvp.Key}");
                    }
                }
            }
        }
    }
}

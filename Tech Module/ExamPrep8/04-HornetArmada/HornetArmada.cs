 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_HornetArmada
{
    class HornetArmada
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var nameAndActivity = new Dictionary<string, long>();
            var nameSoldierTypeAndCount = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var pattern =
                    @"^(?<lastActivity>\d+)\s+=\s+(?<legionName>[^=->:\s]+)\s->\s(?<soldierType>[^=->:\s]+):(?<soldierCount>\d+)";

                var matchedInput = Regex.Match(input, pattern);

                if (matchedInput.Success)
                {
                    long lastActivity = long.Parse(matchedInput.Groups["lastActivity"].Value);
                    string legionName = matchedInput.Groups["legionName"].Value;
                    string soldierType = matchedInput.Groups["soldierType"].Value;
                    long soldierCount = long.Parse(matchedInput.Groups["soldierCount"].Value);

                    if (!nameAndActivity.ContainsKey(legionName))
                    {
                        nameAndActivity[legionName] = lastActivity;
                        nameSoldierTypeAndCount[legionName] = new Dictionary<string, long>();
                        nameSoldierTypeAndCount[legionName][soldierType] = soldierCount;
                    }

                    else
                    {
                        if (!nameSoldierTypeAndCount[legionName].ContainsKey(soldierType))
                        {
                            if (lastActivity > nameAndActivity[legionName])
                            {
                                nameAndActivity[legionName] = lastActivity;
                            }
                            nameSoldierTypeAndCount[legionName].Add(soldierType, soldierCount);
                        }
                        else
                        {
                            if (lastActivity > nameAndActivity[legionName])
                            {
                                nameAndActivity[legionName] = lastActivity;
                            }
                            nameSoldierTypeAndCount[legionName][soldierType] += soldierCount;
                        }
                    }

                }
            }
            var command = Console.ReadLine().Split('\\');

            var result = new Dictionary<string, long>();
            if (command.Length > 1)
            {
                var activity = long.Parse(command[0]);
                var soldierTypeToPrint = command[1];

                foreach (var kvp in nameAndActivity)
                {
                    if (kvp.Value >= activity)
                    {
                        nameSoldierTypeAndCount.Remove(kvp.Key);
                    }
                }

                foreach (var item in nameSoldierTypeAndCount)
                {
                    foreach (var kvp in item.Value)
                    {
                        if (kvp.Key == soldierTypeToPrint)
                        {
                            result[item.Key] = kvp.Value;
                        }
                    }
                }

                foreach (var kvp in result.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
            else
            {
                var soldierTypeToPrint = command[0];

                foreach (var kvp in nameAndActivity.OrderByDescending(a => a.Value))
                {
                    if (nameSoldierTypeAndCount[kvp.Key].ContainsKey(soldierTypeToPrint))
                    {
                        Console.WriteLine($"{kvp.Value} : {kvp.Key}");
                    }
                }
            }
        }
    }
}

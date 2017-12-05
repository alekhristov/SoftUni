using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var idEventPattern = @"^(?<id>\d+)\s+#(?<event>\w+)";
            var idEvent = new Dictionary<string, string>();
            var eventNames = new Dictionary<string, List<string>>();

            while (input != "Time for Code")
            {
                string id = string.Empty;
                string currentEvent = string.Empty;

                var matchedIdAndEvent = Regex.Match(input, idEventPattern);

                if (matchedIdAndEvent.Success)
                {
                    id = matchedIdAndEvent.Groups["id"].Value;
                    currentEvent = matchedIdAndEvent.Groups["event"].Value;

                    var names = input.Split('@')
                        .Skip(1)
                        .Select(a => a.Trim())
                        .ToArray();

                    if (!idEvent.ContainsKey(id))
                    {
                        idEvent[id] = currentEvent;
                        eventNames[currentEvent] = new List<string>();

                        foreach (var name in names.Distinct())
                        {
                            eventNames[currentEvent].Add(name);
                        }
                    }
                    else
                    {
                        if (idEvent[id] == currentEvent)
                        {
                            foreach (var name in names.Distinct())
                            {
                                if (!eventNames[currentEvent].Contains(name))
                                {
                                    eventNames[currentEvent].Add(name);
                                }
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var currentEvent in eventNames.OrderByDescending(a => a.Value.Count).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{currentEvent.Key} - {currentEvent.Value.Count}");

                foreach (var name in currentEvent.Value.OrderBy(a => a))
                {
                    Console.WriteLine($"@{name}");
                }
            }
        }
    }
}

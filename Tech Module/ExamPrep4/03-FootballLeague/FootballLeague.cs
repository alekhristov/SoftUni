using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_FootballLeague
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var regex = Regex.Escape($@"{key}");

            var input = Console.ReadLine();

            var teamGoals = new Dictionary<string, int>();
            var standings = new Dictionary<string, int>();

            while (input != "final")
            {
                string output = Regex.Replace(input, regex, "666");
                var pattern = @"666(?<team>.*?)666";
                var resultPattern = @"(?<team1Goals>\d+):(?<team2Goals>\d+)";


                var matchedTeams = Regex.Matches(output, pattern);
                var result = Regex.Match(output, resultPattern);

                int team1Goals = int.Parse(result.Groups["team1Goals"].Value);
                int team2Goals = int.Parse(result.Groups["team2Goals"].Value);
                var index = 0;

                foreach (Match item in matchedTeams)
                {
                    index++;
                    string team = item.Groups["team"].Value.ToUpper();
                    char[] charArray = team.ToCharArray();
                    Array.Reverse(charArray);
                    string teamReversed = new string(charArray);

                    if (!teamGoals.ContainsKey(teamReversed))
                    {
                        teamGoals[teamReversed] = 0;
                        standings[teamReversed] = 0;
                    }

                    if (index == 1)
                    {
                        teamGoals[teamReversed] += team1Goals;

                        if (team1Goals > team2Goals)
                        {
                            standings[teamReversed] += 3;

                        }
                        else if (team1Goals == team2Goals)
                        {
                            standings[teamReversed] += 1;
                        }
                    }
                    if (index == 2)
                    {
                        teamGoals[teamReversed] += team2Goals;

                        if (team1Goals < team2Goals)
                        {
                            standings[teamReversed] += 3;

                        }
                        else if (team1Goals == team2Goals)
                        {
                            standings[teamReversed] += 1;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            var place = 0;

            Console.WriteLine("League standings:");
            foreach (var team in standings.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
            {
                place++;
                Console.WriteLine($"{place}. {team.Key} {team.Value}");
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in teamGoals.OrderByDescending(t => t.Value).ThenBy(t => t.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }
    }
}

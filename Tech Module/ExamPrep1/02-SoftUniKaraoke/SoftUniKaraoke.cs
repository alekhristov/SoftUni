using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(',').Select(n => n.Trim()).ToList();
            var songsAvailable = Console.ReadLine().Split(',').Select(n => n.Trim()).ToList();
            var nameSongsAward = Console.ReadLine();
            var nameAwards = new Dictionary<string, List<string>>();

            while (nameSongsAward != "dawn")
            {
                var tokens = nameSongsAward.Split(',');
                var name = tokens[0].Trim();
                var song = tokens[1].Trim();
                var award = tokens[2].Trim();

                if (participants.Contains(name) && songsAvailable.Contains(song))
                {
                    if (!nameAwards.ContainsKey(name))
                    {
                        nameAwards[name] = new List<string>();
                    }

                    if (!nameAwards[name].Contains(award) && nameAwards.ContainsKey(name))
                    {
                        nameAwards[name].Add(award);
                    }

                }
                nameSongsAward = Console.ReadLine();
            }

            if (nameAwards.Values.Count < 1)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var kvp in nameAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");

                    foreach (var award in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var logsData = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[1];
                var ip = input[0];
                var duration = int.Parse(input[2]);

                if (!logsData.ContainsKey(name))
                {
                    logsData[name] = new SortedDictionary<string, int>();
                }
                if (!logsData[name].ContainsKey(ip))
                {
                    logsData[name][ip] = 0;
                }
                logsData[name][ip] += duration;
            }
            foreach (var nameIPsDuration in logsData)
            {
                var name = nameIPsDuration.Key;
                var ipsDurations = nameIPsDuration.Value;
                var totalDuration = nameIPsDuration.Value.Values.Sum();
                var ips = ipsDurations.Select(a => a.Key).ToArray();

                Console.WriteLine($"{name}: {totalDuration} [{string.Join(", ", ips)}]");

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExamPrep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, long>>();
            var pattern = @"^(?<root>[A-Z]:|[a-zA-Z]+).*\\(?<fileName>.+);(?<size>\d+)";

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var matchedFile = Regex.Match(input, pattern);

                if (matchedFile.Success)
                {
                    var root = matchedFile.Groups["root"].Value;
                    var fileName = matchedFile.Groups["fileName"].Value;
                    var fileSize = long.Parse(matchedFile.Groups["size"].Value);

                    if (!dict.ContainsKey(root))
                    {
                        dict[root] = new Dictionary<string, long>();
                    }
                    if (dict[root].ContainsKey(fileName))
                    {
                        dict[root][fileName] = 0;
                    }
                    dict[root][fileName] = fileSize;

                }

            }

            var printFile = Console.ReadLine().Split();
            var extension = printFile[0];
            var rootPath = printFile[2];
            bool extensionExist = false;

            foreach (var item in dict.Where(r => r.Key == rootPath))
            {
                foreach (var kvp in item.Value.OrderByDescending(f => f.Value).ThenBy(f => f.Key))
                {
                    if (kvp.Key.ToString().EndsWith(extension))
                    {
                        extensionExist = true;
                        Console.WriteLine($"{kvp.Key} - {kvp.Value} KB");
                    }
                }
            }
            if (!extensionExist)
            {
                Console.WriteLine("No");
            }
        }
    }
}

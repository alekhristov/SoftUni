using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var resources = new Dictionary<string, int>();

            while (input != "stop")
            {
                var quantity = Console.ReadLine();

                if (!resources.ContainsKey(input))
                {
                    resources[input] = 0;
                }
                resources[input] += int.Parse(quantity);

                input = Console.ReadLine();
            }
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
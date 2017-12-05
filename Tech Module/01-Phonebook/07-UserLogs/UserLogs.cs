using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var usersIDs = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                var tokens = input.Split();
                var tokensUser = tokens[2].Split('=');
                var tokensIP = tokens[0].Split('=');
                string user = tokensUser[1];
                string IP = tokensIP[1];

                if (!usersIDs.ContainsKey(user))
                {
                    usersIDs[user] = new Dictionary<string, int>();

                    if (!usersIDs[user].ContainsKey(IP))
                    {
                        usersIDs[user][IP] = 1;
                    }
                }
                else
                {
                    int value = 1;

                    if (usersIDs[user].ContainsKey(IP))
                    {
                        value = usersIDs[user][IP];
                        value++;
                    }
                    usersIDs[user][IP] = value;
                }
                input = Console.ReadLine();
            }

            foreach (var person in usersIDs)
            {
                Console.WriteLine($"{person.Key}: ");

                foreach (var kvp in person.Value)
                {
                    if (kvp.Key != person.Value.Keys.Last())
                    {
                        Console.Write($"{kvp.Key} => {kvp.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{kvp.Key} => {kvp.Value}.");
                    }
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_UpgradedPhonebook
{
    class UpgradedPhonebook
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                var command = input[0];

                if (command == "A")
                {
                    var name = input[1];
                    var number = input[2];

                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook[name] = string.Empty;
                    }
                    phonebook[name] = number;
                }
                else if (command == "S")
                {
                    var name = input[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}

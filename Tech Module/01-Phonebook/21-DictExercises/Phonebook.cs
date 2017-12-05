using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_DictExercises
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var phonebook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                var command = input[0];
                var name = input[1];

                if (command == "A")
                {
                    var number = input[2];

                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook[name] = string.Empty;
                    }
                    phonebook[name] = number;
                }
                else if (command == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}

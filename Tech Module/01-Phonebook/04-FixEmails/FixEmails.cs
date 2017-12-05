using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var emailAddressbook = new Dictionary<string, string>();

            while (input != "stop")
            {
                var email = Console.ReadLine();

                if (!email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    emailAddressbook[input] = email;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine();
            foreach (var kvp in emailAddressbook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

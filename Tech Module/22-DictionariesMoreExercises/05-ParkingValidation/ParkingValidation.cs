using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ParkingValidation
{
    class ParkingValidation
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var parkingBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                var command = input[0];
                var user = input[1];

                if (command == "register")
                {
                    var number = input[2];

                    if (parkingBook.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingBook[user]}");
                    }
                    else if (!IsLicenseValid(number))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {number}");
                    }
                    else if (parkingBook.ContainsValue(number))
                    {
                        Console.WriteLine($"ERROR: license plate {number} is busy");
                    }
                    else if (!parkingBook.ContainsKey(user))
                    {
                        parkingBook[user] = number;
                        Console.WriteLine($"{user} registered {number} successfully");
                    }

                }
                else if (command == "unregister")
                {
                    if (!parkingBook.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        Console.WriteLine($"user {user} unregistered successfully");
                        parkingBook.Remove(user);
                    }
                }
            }
            foreach (var user in parkingBook)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }

        }
        public static bool IsLicenseValid(string number)
        {
            if (number.Length == 8
                && number.Take(2).All(char.IsUpper)
                && number.Skip(2).Take(4).All(char.IsDigit)
                && number.Skip(6).Take(2).All(char.IsUpper))
            {
                return true;
            }
            return false;
        }
    }
}

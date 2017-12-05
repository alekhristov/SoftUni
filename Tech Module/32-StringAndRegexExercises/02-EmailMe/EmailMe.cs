using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EmailMe
{
    class EmailMe
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('@');
            var user = input[0].ToCharArray();
            var host = input[1].ToCharArray();
            int sumUser = 0;
            int sumHost = 0;

            for (int i = 0; i < user.Length; i++)
            {
                sumUser += user[i];
            }
            for (int i = 0; i < host.Length; i++)
            {
                sumHost += host[i];
            }
            if (sumUser - sumHost >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(@" /\,".ToCharArray()).ToArray();
            var pattern = @"\b([a-zA-Z]\w{2,24})\b";

            var matchedUsernames = Regex.Matches(string.Join(" ", input), pattern);

            int sum = 0;
            int maxSum = 0;
            int index = 0;

            var listOfUsernames = new List<string>();

            foreach (Match username in matchedUsernames)
            {
                listOfUsernames.Add(username.Value);
            }

            for (int i = 0; i < listOfUsernames.Count - 1; i++)
            {
                sum += listOfUsernames[i].Length + listOfUsernames[i + 1].Length;

                if (sum > maxSum)
                {
                    maxSum = sum;
                    index = i;
                }

                sum = 0;
            }

            Console.WriteLine(listOfUsernames[index]);
            Console.WriteLine(listOfUsernames[index+1]);
        }
    }
}

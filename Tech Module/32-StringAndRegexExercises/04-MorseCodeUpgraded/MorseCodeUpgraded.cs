using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MorseCodeUpgraded
{
    class MorseCodeUpgraded
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');
            var sum = 0;
            var sequence = 1;
            var listOfSums = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentMessage = input[i].Trim();
                sum = 0;
                sequence = 1;

                for (int k = 0; k < currentMessage.Length; k++)
                {
                    if (currentMessage[k] == '0')
                    {
                        sum += 3;
                    }
                    else if (currentMessage[k] == '1')
                    {
                        sum += 5;
                    }
                    if (k < currentMessage.Length - 1)
                    {
                        if (currentMessage[k] == currentMessage[k + 1])
                        {
                            sequence++;
                        }
                        else
                        {
                            if (sequence > 1)
                            {
                                sum += sequence;
                            }
                            sequence = 1;
                        }
                    }
                    else if (k == currentMessage.Length - 1)
                    {
                        if (sequence > 1)
                        {
                            sum += sequence;
                        }
                    }
                }
                listOfSums.Add(sum);
            }
            foreach (var item in listOfSums)
            {
                Console.Write((char)item);
            }
            Console.WriteLine();
        }
    }
}

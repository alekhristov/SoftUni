using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OddFilter
{
    class OddFilter
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < nums.Count; i++)
            {
                if ((double)nums[i] > nums.Average())
                {
                    nums[i]++;
                }
                else
                {
                    nums[i]--;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

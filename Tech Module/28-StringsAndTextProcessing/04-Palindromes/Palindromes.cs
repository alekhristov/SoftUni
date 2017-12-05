using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(",? !.".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var listResult = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                //if (text[i].SequenceEqual(text[i].Reverse()))
                //{
                //    listResult.Add(text[i]);
                //}
                if (GetStatus(text[i]))
                {
                    listResult.Add(text[i]);
                }
            }
            listResult = listResult.Distinct().OrderBy(a => a).ToList();

            Console.WriteLine(string.Join(", ", listResult));

        }
        public static bool GetStatus(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }
    }
}

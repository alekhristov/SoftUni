using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_Censorship
{
    class Censorship
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentence = Console.ReadLine();

            var asd = Regex.Replace(sentence, $@"{word}", new string('*', word.Length));
            Console.WriteLine(asd);

            //if (sentence.Contains(word))
            //{
            //    sentence = sentence.Replace(word, new string('*', word.Length));
            //}
            //Console.WriteLine(sentence);

        }
    }
}

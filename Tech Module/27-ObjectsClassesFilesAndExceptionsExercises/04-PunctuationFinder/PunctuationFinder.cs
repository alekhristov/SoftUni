using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PunctuationFinder
{
    class PunctuationFinder
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadLines
                (@"C:\Users\alekhristov\Desktop\VS Projects\27-ObjectsClassesFilesAndExceptionsExercises\sample_text.txt");
            var punctuation = new List<char>();
            char[] punctuationSigns = new char[] { '.', ',', '!', '?', ':' };

            foreach (var line in allLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (punctuationSigns.Contains(line[i]))
                    {
                        punctuation.Add(line[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", punctuation));
        }
    }
}

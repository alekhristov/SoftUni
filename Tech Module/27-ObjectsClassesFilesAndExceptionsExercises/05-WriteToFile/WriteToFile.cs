using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_WriteToFile
{
    class WriteToFile
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllText
               (@"C:\Users\alekhristov\Desktop\VS Projects\27-ObjectsClassesFilesAndExceptionsExercises\sample_text.txt")
               .Split(new char[] { '.', ',', '!', '?', ':', },
                StringSplitOptions.RemoveEmptyEntries);

            File.WriteAllText(@"C:\Users\alekhristov\Desktop\VS Projects\27-ObjectsClassesFilesAndExceptionsExercises\output.txt", string.Join("", allLines));

            Console.WriteLine(File.ReadAllText(@"C:\Users\alekhristov\Desktop\VS Projects\27-ObjectsClassesFilesAndExceptionsExercises\output.txt"));
        }
    }
}

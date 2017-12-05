using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_CameraView
{
    class CameraView
    {
        static void Main(string[] args)
        {
            var skipTake = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var skip = skipTake[0] + 2;
            var take = skipTake[1];

            var input = Console.ReadLine();
            var pattern = @"(\|<\w+)";

            var matchedPictures = Regex.Matches(input, pattern);
            var result = new List<string>();

            foreach (Match picture in matchedPictures)
            {
                result.Add(string.Join("", picture.Value.Skip(skip).Take(take).ToArray()));
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}

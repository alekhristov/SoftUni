﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<day>[0-9]{2})([.|\-|\/])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";
            var input = Console.ReadLine();

            var matchedDates = Regex.Matches(input, pattern);

            foreach (Match date in matchedDates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }


        }
    }
}

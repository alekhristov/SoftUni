﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07_Hideout
{
    class Hideout
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();


            while (true)
            {
                var tokens = Console.ReadLine().Split();
                var pattern = @"\" + tokens[0] + "{" + tokens[1] + ",}";

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    Console.WriteLine($"Hideout found at index {input.IndexOf(match.Value)} and it is with size {match.Value.Length}!");
                    break;
                }
            }
        }
    }
}

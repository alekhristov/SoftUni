using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r = size[0];
            var c = size[1];

            var matrix = new string[r, c];

            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    var element = $"{alphabet[row]}{alphabet[row + col]}{alphabet[row]}";
                    matrix[row, col] = element;
                }
            }

            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    if (col == c - 1)
                    {
                        Console.WriteLine(matrix[row, col]);
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
            }
        }
    }
}

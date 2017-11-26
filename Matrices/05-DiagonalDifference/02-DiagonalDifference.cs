using System;
using System.Linq;

namespace _05_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];
            long firstDiagonal = 0;
            long secondDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                var inputRow = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            var column = n - 1;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        firstDiagonal += matrix[row, col];
                    }
                }
                secondDiagonal += matrix[row, column];
                column--;
            }

            long result = Math.Abs(firstDiagonal - secondDiagonal);
            Console.WriteLine(result);
        }
    }
}

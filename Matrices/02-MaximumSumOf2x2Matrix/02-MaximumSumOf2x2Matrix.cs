using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MaximumSumOf2x2Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var n = matrixSize[0];
            var m = matrixSize[1];
            var matrix = new int[n, m];
            var sum = 0;
            var maxSum = 0;


            for (int rows = 0; rows < n; rows++)
            {
                var inputRow = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int cols = 0; cols < m; cols++)
                {
                    matrix[rows, cols] = inputRow[cols];
                }
            }

            int startRow = 0;
            int startCol = 0;

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    sum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startRow = rows;
                        startCol = cols;
                    }
                }
            }

            Console.WriteLine($"{matrix[startRow, startCol]} {matrix[startRow, startCol + 1]}");
            Console.WriteLine($"{matrix[startRow + 1, startCol]} {matrix[startRow + 1, startCol + 1]}");
            Console.WriteLine(maxSum);

        }
    }
}

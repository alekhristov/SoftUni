﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Rubik_sMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[matrixSize[0], matrixSize[1]];
            var initialMatrix = new int[matrixSize[0], matrixSize[1]];
            var counter = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            initialMatrix = (int[,])matrix.Clone();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                var rowOrColumn = int.Parse(command[0]);
                var direction = command[1];
                var numberOfMoves = int.Parse(command[2]);

                switch (direction)
                {
                    case "left":
                        var currentRow = rowOrColumn;
                        for (int j = 0; j < numberOfMoves; j++)
                        {
                            var firstElement = matrix[currentRow, 0];
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                if (col == matrix.GetLength(1) - 1)
                                {
                                    matrix[currentRow, matrix.GetLength(1) - 1] = firstElement;
                                    break;
                                }
                                matrix[currentRow, col] = matrix[currentRow, col + 1];
                            }
                        }
                        break;

                    case "right":
                        currentRow = rowOrColumn;
                        for (int j = 0; j < numberOfMoves; j++)
                        {
                            var lastElement = matrix[currentRow, matrix.GetLength(1) - 1];
                            for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                            {
                                if (col == 0)
                                {
                                    matrix[currentRow, col] = lastElement;
                                    break;
                                }
                                matrix[currentRow, col] = matrix[currentRow, col - 1];
                            }
                        }
                        break;

                    case "up":
                        for (int j = 0; j < numberOfMoves; j++)
                        {
                            var firstElement = matrix[0, rowOrColumn];
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                if (row == matrix.GetLength(0) - 1)
                                {
                                    matrix[row, rowOrColumn] = firstElement;
                                    break;
                                }
                                matrix[row, rowOrColumn] = matrix[row + 1, rowOrColumn];
                            }
                        }
                        break;

                    case "down":
                        for (int j = 0; j < numberOfMoves; j++)
                        {
                            var lastElement = matrix[matrix.GetLength(0) - 1, rowOrColumn];
                            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                            {
                                if (row == 0)
                                {
                                    matrix[row, rowOrColumn] = lastElement;
                                    break;
                                }
                                matrix[row, rowOrColumn] = matrix[row - 1, rowOrColumn];
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            bool needsToBreak = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (initialMatrix[row, col] != matrix[row,col])
                    {
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (initialMatrix[row, col] == matrix[i, j])
                                {
                                    Console.WriteLine($"Swap ({row}, {col}) with ({i}, {j})");
                                    needsToBreak = true;
                                    break;
                                }
                            }
                            if (needsToBreak)
                            {
                                needsToBreak = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No swap required");
                    }
                }
            }
        }
    }
}
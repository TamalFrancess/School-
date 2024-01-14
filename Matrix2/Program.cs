using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int matrixRow = size[0];
            int matrixColumn = size[1];
            int[,] matrix = new int[matrixRow, matrixColumn];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] element = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; row < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = element[col];
                }

            }
            for (int row = 0; row < matrixRow; row++)
            {
               
                for (int col = 0; row < matrix.GetLength(0); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}

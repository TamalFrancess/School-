using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            string[] bombCoordinates = Console.ReadLine().Split();

            foreach (var bomb in bombCoordinates)
            {
                string[] coordinates = bomb.Split(',');
                int row = int.Parse(coordinates[0]);
                int col = int.Parse(coordinates[1]);

                DetonateBomb(matrix, row, col);
            }
            int aliveCells = 0;
            int sumOfCells = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row][col] > 0)
                    {
                        aliveCells++;
                        sumOfCells += matrix[row][col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumOfCells}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }


        }
        static void DetonateBomb(int[][] matrix, int row, int col)
        {
            if (matrix[row][col] > 0)
            {
                int damage = matrix[row][col];
                matrix[row][col] = 0;

                for (int i = row - 1; i <= row + 1; i++)
                {
                    for (int j = col - 1; j <= col + 1; j++)
                    {
                        if (ValidPosition(matrix, i, j))
                        {
                            matrix[i][j] -= damage;
                        }
                    }
                }
            }
        }
        static bool ValidPosition(int[][] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
        }

    }
}

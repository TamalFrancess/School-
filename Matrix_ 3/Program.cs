using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split();
            int n = int.Parse(dimensions[0]);
            int m = int.Parse(dimensions[1]);

            string snake = Console.ReadLine();

            char[,] matrix = new char[n, m];

            int snakeIndex = 0;
            for (int row = 0; row < n; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < m; col++)
                    {
                        matrix[row, col] = snake[snakeIndex % snake.Length];
                        snakeIndex++;
                    }
                }
                else
                {
                    for (int col = m - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[snakeIndex % snake.Length];
                        snakeIndex++;
                    }
                }
            }
            for (int row = 0; row < n; ++row)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col] + "");
                }
                Console.WriteLine();
            }
        }
    }
}

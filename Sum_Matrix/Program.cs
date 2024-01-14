using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ")
   .Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                  .Split(", ")
                  .Select(int.Parse)
                  .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = colElements[col];
            }

        }
    }
}

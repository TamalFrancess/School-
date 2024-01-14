using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimentional_Array_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            int diagonalSum = FindPrimeryDiagonalSum(matrix, matrixSize);
            Console.WriteLine(diagonalSum);


        }
        static int FindPrimeryDiagonalSum(int[,] matrix, int size)
        {
            int diagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                diagonalSum += matrix[i, i];
            }
            return diagonalSum;
        }
    }
}

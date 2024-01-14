using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Multidimentional_Arrays_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                string rowValues = Console.ReadLine();

                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = rowValues[j];
                }
            }
            char symbolToFind = char.Parse(Console.ReadLine());
            int row = -1, col = -1;
            bool symbolFound = FindSymbolPosition(matrix, matrixSize, symbolToFind, out row, out col);

            if (symbolFound)
            {
                Console.WriteLine($"({row}, {col})");
            }
            else
            {
                Console.WriteLine($"{symbolToFind} does not occur in the matrix");
            }
        }
        static bool FindSymbolPosition(char[,] matrix, int size, char symbol, out int row, out int col)
        {
            row = -1;
            col = -1;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        row = i;
                        col = j;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

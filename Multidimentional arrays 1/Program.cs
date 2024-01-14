using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimentional_arrays_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[,] value = new char[size[0], size[1]];

            for (int row = 0; row < size[0]; row++)
            {
                char[] input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int col = 0; col < input.Length; col++)
                {
                    value[row, col] = input[col];
                }
            }
            int count = 0;
            for (int row = 0; row < size[0] - 1; row++)
            {
                for (int col = 0; col < size[1] - 1; col++)
                {
                    if (CheckIfEqual(row, col, value))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
        static bool CheckIfEqual(int row, int col, char[,] value)
        {
            if (value[row, col] == value[row + 1, col] &&
                value[row, col] == value[row, col + 1] &&
                value[row, col] == value[row + 1, col + 1])
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharecter(input);
        }
        static void PrintMiddleCharecter(string str)
        {
            int length = str.Length;


            if (length % 2 == 0)
            {
                int middle1 = length / 2 - 1;
                int middle2 = length / 2;

                Console.WriteLine($"{str[middle1]}{str[middle2]}");
            }
            else
            {
                int middle = length / 2;

                Console.WriteLine($"{str[middle]}");
            }
        }
    }
}

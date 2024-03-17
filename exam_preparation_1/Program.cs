using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_preparation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] transactions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int tasks = int.Parse(Console.ReadLine());
            int working = 0;
            int work = 0;
            int allWork = 0;
            for (int j = 0; j < transactions.Length; j++)
            {
                allWork = allWork + transactions[j];
            }

            for (int i = 0; i < tasks; i = 0)
            {
                work++;
                working++;
                if (working == 4)
                {
                    work++;
                    working = 0;
                }
                tasks = tasks - allWork;
            }
            Console.WriteLine($"Time needed: {work}h.");
        }
    }
}

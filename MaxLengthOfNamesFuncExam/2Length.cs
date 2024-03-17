using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxLengthOfNamesFuncExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ');

            PrintNamesByLength(names, n);
        }

        static void PrintNamesByLength(string[] names, int maxLength)
        {
            var filteredNames = names.Where(name => name.Length <= maxLength);

            foreach (string name in filteredNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}

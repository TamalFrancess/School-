using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)2
                .Select(double.Parse)
                .ToList();

            Dictionary<double, int> dictNums = new Dictionary<double, int>();
            foreach (var number in numbers)
            {
                if (!dictNums.ContainsKey(number))
                {
                    dictNums.Add(number, 1);
                }
                else
                {
                    dictNums[number]++;
                }
            }
            foreach (var kvp  in dictNums)
            {
                Console.WriteLine($"{kvp.Key}");
            }
        }
    }
}

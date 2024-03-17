using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1Sets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> uniqueElements = new HashSet<string>();



            for (int i = 0; i < n; i++)
            {
                string[] compounds = Console.ReadLine().Split(' ');
                foreach (string compound in compounds)
                {
                    uniqueElements.Add(compound);
                }
            }

            List<string> sortedUniqueElements = uniqueElements.ToList();
            sortedUniqueElements.Sort();


            foreach (string element in sortedUniqueElements)
            {
                Console.WriteLine(element);
            }
        }
    }
}

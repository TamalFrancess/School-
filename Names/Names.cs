using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    internal class Names
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(i);
                string name = Console.ReadLine();
                names.Add(name);
            }
            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}

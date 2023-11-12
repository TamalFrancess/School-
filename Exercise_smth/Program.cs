using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_smth
{
    internal class Program
    {

        static void Number(int n1, int n2, int n3)
        {
            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine(n1);
            }
            if (n2 < n1 && n2 < n3)
            {
                Console.Write(n2);
            }
            if (n3 < n2 && n3 < n1)
            {
                Console.Write(n3);
            }
        }
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            Number(n1, n2, n3);
            
        }
    }
}

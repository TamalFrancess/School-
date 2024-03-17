using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace naming_sir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputN = Console.ReadLine();

            string[] names = inputN.Split(' ');

            Action<string[]> addSir = (nameArray) =>
            {
                foreach (string name in nameArray)
                {
                    string sirName = "Sir " + name;
                    Console.WriteLine(sirName);
                }
            };
            addSir(names);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_exercise_33
{
    internal class Program
    {

        static void Print(char start, char end)
        {
            char startCh;
            char endCh;

            if(start < end)
            {
                startCh = start;
                endCh = end;
            }
            else
            {
                startCh = end;
                endCh = start;
            }

            for (int i = ++startCh; i < endCh; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());

            Print(input1,input2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine()); 
            int num2 = int.Parse(Console.ReadLine());

            long factorial1 = CalculateFactorial(num1);
            long factorial2 = CalculateFactorial(num2);

            double result = (double)factorial1 / factorial2;

            Console.WriteLine($"{factorial1}{factorial2}{result:F2}");
        }
        static long CalculateFactorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                long factorial = 1; 
                for (int i = 2; i <= num; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
            int X = int.Parse(Console.ReadLine());
           
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                int element = int.Parse(Console.ReadLine());
                stack.Push(i);
            }

            for (int i = 0;i < S; i++)
            {
                if (stack.Count > 0)
                stack.Pop();
            }

            if (stack.Contains(X))
            {
                Console.WriteLine("found");
            }
            else if (stack.Count > 0 )
            {
                int smallestElement = int.MinValue;
                foreach (int element in stack)
                {
                    if (element < smallestElement)
                    {
                        smallestElement = element;
                    }
                }
  

            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6th_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split()
                .Select(int.Parse). ToArray() ;

            Array.Sort(arr) ;

            List<int> sortedList = new List<int>() ;

            Func <int, bool> func = x => x%2 == 0 ;

            foreach (int num in arr)
            {
                if (func(num))
                {
                    sortedList.Add(num) ;
                }
            }

            foreach (int num in arr)
            {
                if (!func(num))
                {
                    sortedList.Add(num);
                }
            }

            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));
            print(sortedList);  




        }
    }
}

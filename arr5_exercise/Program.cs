using System;
using System.Linq;

namespace arr5_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 3, 2 };
            int[] array2 = { 1, 2 };
            int[] array3 = {1, 0 };
            int[] array4 = { 1, 2, 3 };
            int[] array5 = { 10, 5, 5, 99, 3, 4, 2, 5, 1, 1, 4 };


            int result1 = FindEquilibriumIndex(array1);
            int result2 = FindEquilibriumIndex(array2);
            int result3 = FindEquilibriumIndex(array3);
            int result4 = FindEquilibriumIndex(array4);
            int result5 = FindEquilibriumIndex(array5);


            Console.WriteLine(result1 == -1 ? "no" : result1.ToString());
            Console.WriteLine(result2 == -1 ? "no" : result2.ToString());
            Console.WriteLine(result3 == -1 ? "no" : result3.ToString());
            Console.WriteLine(result4 == -1 ? "no" : result4.ToString());
            Console.WriteLine(result5 == -1 ? "no" : result5.ToString());

            static int FindEquilibriumIndex(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int leftSum = array.Take(i).Sum();
                    int rightSum = array.Skip(i + 1).Sum();

                    if (leftSum == rightSum)
                    {
                        return i;
                    }
                }
                return -1;
            }

        }
    }
}
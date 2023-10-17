using System;
using System.Collections.Generic;


namespace arr4_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 4, 3, 2, 4, 3, 2 };
            int[] array2 = { 14, 24, 3, 19, 15, 17, 24, 19, 17 };
            int[] array3 = { 27, 19, 42, 2, 13, 45, 48, 48 };

            List<int> topIntegers1 = FindTopIntegers(array1);
            List<int> topIntegers2 = FindTopIntegers(array2);
            List<int> topIntegers3 = FindTopIntegers(array3);

            Console.WriteLine(string.Join(" ", topIntegers1));
            Console.WriteLine( string.Join(" ", topIntegers3));
            Console.WriteLine(string.Join(" ", topIntegers2));

            static List<int> FindTopIntegers(int[] array)
            {
                List<int> topIntegers = new List<int>();

                int maxRight = int.MinValue;

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] > maxRight)
                    {
                        topIntegers.Add(array[i]);
                        maxRight = array[i];
                    }
                }
                topIntegers.Reverse();
                return topIntegers;
            }
        }
    }
}
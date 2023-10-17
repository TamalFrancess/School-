using System;
using System.Linq;

namespace arr6_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int longestSequenceStart = 0;
            int longestSequenceLength = 1;
            int currentSequenceStart = 0;
            int currentSequenceLength = 1;


            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentSequenceLength++;
                }
                else
                {
                    currentSequenceStart = i;
                    currentSequenceLength = 1;
                }
                
                if (currentSequenceLength > longestSequenceLength)
                {
                    longestSequenceStart = currentSequenceStart;
                    longestSequenceLength = currentSequenceLength;
                }
            }
            int[] longestSeguence = new int[longestSequenceLength];
            Array.Copy(arr, longestSequenceStart, longestSeguence, 0, longestSequenceLength);

            Console.WriteLine(string.Join(" ", longestSeguence));
        }
    }
}
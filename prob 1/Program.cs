using System;
using System.Collections.Generic;
using System.Linq;


namespace prob_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> items = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            int startIndex = int.Parse(Console.ReadLine());
            string priceRatings = Console.ReadLine();

            int leftSum = 0;
            int rightSum = 0;
            if (priceRatings == "cheap")
            {
                leftSum = items
                    .Take(startIndex)
                    .Where(x => x < items[startIndex])
                    .Sum();
                rightSum = items
                    .Skip(startIndex +1)
                    .Where(x => x < items[startIndex])
                    .Sum();
            }
            else if (priceRatings == "expensive")
            {
                leftSum = items
                    .Take(startIndex)
                    .Where(x => x >= items[startIndex])
                    .Sum();
                rightSum = items
                    .Skip(startIndex)
                    .Where(x => x >= items[startIndex])
                    .Sum();
            }
            if (rightSum <= leftSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }



        }   
    }
}

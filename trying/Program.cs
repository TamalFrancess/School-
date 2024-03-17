using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trying
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split();
            int[] priceRatings = new int[inputStrings.Length];
            for (int i = 0; i < inputStrings.Length; i++)
            {
                priceRatings[i] = int.Parse(inputStrings[i]);
            }

            int entryPoint = int.Parse(Console.ReadLine());
            string itemType = Console.ReadLine();

            // Calculate damage on both sides
            int leftDamage = CalculateDamage(priceRatings, entryPoint, itemType, isLeft: true);
            int rightDamage = CalculateDamage(priceRatings, entryPoint, itemType, isLeft: false);

            // Print the result
            if (leftDamage >= rightDamage)
            {
                Console.WriteLine($"left - {leftDamage}");
            }
            else
            {
                Console.WriteLine($"right - {rightDamage}");
            }
        }

        static int CalculateDamage(int[] priceRatings, int entryPoint, string itemType, bool isLeft)
        {
            int damage = 0;

            // Calculate damage based on the item type and direction
            if (isLeft)
            {
                for (int i = 0; i < entryPoint; i++)
                {
                    if ((itemType == "cheap" && priceRatings[i] < priceRatings[entryPoint]) ||
                        (itemType == "expensive" && priceRatings[i] > priceRatings[entryPoint]))
                    {
                        damage += priceRatings[i];
                    }
                }
            }
            else
            {
                for (int i = entryPoint + 1; i < priceRatings.Length; i++)
                {
                    if ((itemType == "cheap" && priceRatings[i] < priceRatings[entryPoint]) ||
                        (itemType == "expensive" && priceRatings[i] > priceRatings[entryPoint]))
                    {
                        damage += priceRatings[i];
                    }
                }
            }

            return damage;
        }
    }
}

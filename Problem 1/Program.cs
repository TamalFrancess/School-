using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split();
            int[] prices = new int[inputStrings.Length];

            for (int i = 0; i < inputStrings.Length; i++)
            {
                prices[i] = int.Parse(inputStrings[i]);
            }
            int entryPoint = int.Parse(Console.ReadLine());
            string itemType = Console.ReadLine();
            int rightDamage = CalculateDamage(prices, entryPoint, itemType, onTheLeft:true);
            int leftDamage =CalculateDamage(prices, entryPoint, itemType, onTheLeft:false);

            
            if (rightDamage >= leftDamage)
            {
                Console.WriteLine($"Left damage - {leftDamage}.");
                
            }
            else
            {
                Console.WriteLine($"Right damage - {rightDamage}.");
            }
        }
        static int CalculateDamage(int[] prices, int entryPoint,  string itemType, bool onTheLeft)
        {
            int damage = 0;
           
            if(onTheLeft)
            {
                for (int i = 0;i < entryPoint ;i++)
                {
                    if (itemType == "cheap" && prices[i] < prices[entryPoint] ||
                        (itemType == "expensive" && prices[i] > prices[entryPoint]))
                    {
                        damage += prices[i];
                    }
                }
            }
            else
            {
                for (int i = entryPoint +1; i < prices.Length;i++)
                {
                    if ((itemType == "cheap" && prices[i] < prices[entryPoint]) ||
                        (itemType == "expensive" && prices[i] > prices[entryPoint]))
                    {
                        damage += prices[i];
                    }
                }
            }
            return damage;
        }
    }
}

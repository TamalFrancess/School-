using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] steel = Console.ReadLine().Split().Select(int.Parse).ToArray();

            
           
            int[] carbon = Console.ReadLine().Split().Select(int.Parse).ToArray();

            
            Dictionary<string, int> swords = new Dictionary<string, int>
        {
            { "Gladius", 70 },
            { "Shamshir", 80 },
            { "Katana", 90 },
            { "Sabre", 110 },
            { "Broadsword", 150 }
        };

           
            int totalSwordsForged = 0;

            while (steel.Any() && carbon.Any())
            {
                int currentSteel = steel[0];
                int currentCarbon = carbon[carbon.Length - 1];

                int totalValue = currentSteel + currentCarbon;
            }
        }
    }
}

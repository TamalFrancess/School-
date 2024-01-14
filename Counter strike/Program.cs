using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Counter_strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wonBattles = 0;
            int initialEnergy = int.Parse(Console.ReadLine());
            int currentEnergy = initialEnergy;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End of battle")
                {
                    Console.WriteLine($"Won battles: {wonBattles}. Energy left: {currentEnergy}");
                    break;
                }
                int distance = int.Parse(input);

                if (currentEnergy >= distance)
                {
                    currentEnergy -= distance;
                    wonBattles++;

                    if (wonBattles % 3 == 0)
                    {
                        currentEnergy += wonBattles;
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

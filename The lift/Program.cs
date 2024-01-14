using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInQueue = int.Parse(Console.ReadLine());
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < wagons.Count; i++)
            {
                int availableSpace = 4 - wagons[i];

                if (availableSpace > 0)
                {
                    int peopleToAdd = Math.Min(availableSpace, peopleInQueue);
                    wagons[i] += peopleToAdd;
                    peopleInQueue -= peopleToAdd;
                }

                if (peopleInQueue == 0)
                    break;
            }

            if (peopleInQueue == 0 && wagons.Sum() < wagons.Count * 4)
            {
                Console.WriteLine("The lift has empty spots!\n" + string.Join(" ", wagons));
            }
            else if (peopleInQueue > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleInQueue} people in a queue!\n{string.Join(" ", wagons)}");
            }
            else
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}

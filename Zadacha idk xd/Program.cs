using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_idk_xd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> traffic = new Queue<string>();
            int passedCars = 0;
            bool isCrashed = false;
            string car = string.Empty;
            int carHit = 0;

            while (command.ToUpper() != "STOP")
            {
                if (command.ToUpper() != "light")
                {
                    traffic.Enqueue(command);
                }

                else
                {
                    int greenLightDuration = greenLight;
                    int freeWindowDuration = freeWindow;
                    for (int i = 0; i < traffic.Count; i++)
                    {
                        string currentCar = traffic.Dequeue();
                        if (greenLightDuration >= currentCar.Length)
                        {
                            greenLightDuration -= currentCar.Length;
                            passedCars++;
                        }
                        else if (greenLightDuration + freeWindowDuration > currentCar.Length)
                        {

                            passedCars++;
                        }
                        else
                        {
                            isCrashed = true;
                            car = currentCar;
                            carHit = currentCar.Length - (greenLightDuration - freeWindowDuration);
                            break;

                        }

                    }

                }

                command = Console.ReadLine();
            }
            if (isCrashed)
            {
                Console.WriteLine("Accident!");
                Console.WriteLine($"{car} was crushed at {carHit}.");
            }
            else
            {
                Console.WriteLine("Success!");
                Console.WriteLine($"{passedCars} total cars are gone.");
            }
        }
    }
}

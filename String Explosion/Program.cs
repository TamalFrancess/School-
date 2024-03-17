using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = RemoveExplosions(input);
            Console.WriteLine(result);
        }
        static string RemoveExplosions(string input)
        {
            StringBuilder result = new StringBuilder();
            int strength = 0;

            foreach (char c in input)
            {
                if (c == '>')
                {
                    result.Append(c);
                    if (strength > 0)
                    {
                        strength += int.Parse(input[result.Length].ToString());

                    }
                }
                else if (strength == 0)
                {
                    result.Append(c);
                }
                else
                {
                    strength--;
                }
            }
            return result.ToString();
        }
    }
}

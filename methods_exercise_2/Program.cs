using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = 0;
            Vows(word, count);

        }

        static void Vows(string words, int count)
        {
            foreach(char c in words)
            {
                if (c ==  'a' || c ==  'A' || c == 'o' || c == 'O' || c == 'u' || c == 'U' || c == 'e' || c == 'E' || c == 'i' || c == 'I')
                {
                    count++;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}

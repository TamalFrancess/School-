using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                string input = Console.ReadLine(); 

                if (input.ToLower() == "end")
                {
                    break;
                }

                bool isPalindrome = IsPalindrome(input);
                Console.WriteLine(isPalindrome);
            }
        }
        static bool IsPalindrome(string str)
        {
            int length = str.Length;
            for (int i = 0; i < length /2;i++)
            {
                if (str[i] != str[length - 1 - i]) {

                    return false;
                }
            }
            return true;
        }
    }
}

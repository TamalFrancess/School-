using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            if (ValidatePassword(password))
            {
                Console.WriteLine("Password is valid");
            }
            
        }

        static void ValidatePassword(string password)
        {
            bool isValid = true;

            if (password.Length < 6 || password.Length > 10) 
            {
                Console.WriteLine("Password must be between 6 and 10 characters.");
                isValid = false;
            }
            if (password.Length < 'a' ||  password.Length > 'Z')
            {
                Console.WriteLine("Password must consist only of letters and digits.");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid.");
            }
        }
    }
}

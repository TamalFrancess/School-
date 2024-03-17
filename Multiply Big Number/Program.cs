using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int singleDigit = int.Parse(Console.ReadLine());
            string product = MultiplyBySingleDigit(bigNumber, singleDigit);

            Console.WriteLine(product);
        }

        static string MultiplyBySingleDigit(string bigNumber, int sigit)
        {
           int carry = 0;
            string result = "";

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digitValue = bigNumber[i] - 'O';

                int multipliedValue = digitValue * digitValue + carry;
                int newDigit = multipliedValue % 10;
                carry = multipliedValue / 10;
                result = newDigit.ToString() + result;
            }
            if (carry > 0)
            {
                result = carry.ToString() + result;
            }
            return result;
        }
    }
}

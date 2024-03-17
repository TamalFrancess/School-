using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string encryptedText = EncyptText(text);

            Console.WriteLine(encryptedText);
        }
        static string EncyptText(string text)
        {
            char[] chars = text.ToCharArray();

            for(int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    int ansciiValue = (int)chars[i];

                    int newAsciiValue = ansciiValue + 3;

                    if (char.IsLower(chars[i]) && newAsciiValue > (int)'z')
                    {
                        newAsciiValue = (newAsciiValue - (int)'z' - 1) + (int)'a';
                    }

                    else if (char.IsUpper(chars[i]) && newAsciiValue > (int)'Z')
                    {
                        newAsciiValue = (newAsciiValue - (int)'Z' - 1) + (int)'A';
                    }
                    chars[i] = (char)newAsciiValue;
                }
            }
            return new string(chars);
        }
    }
}

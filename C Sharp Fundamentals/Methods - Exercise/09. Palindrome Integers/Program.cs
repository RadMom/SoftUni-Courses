using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            while (number != "END")
            {
                PolindromeInteger(number);

                number = Console.ReadLine();
            }
        }

        private static void PolindromeInteger(string number)
        {
            string reversed = string.Empty;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed += number[i];
            }

            if (reversed == number)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}

using System;

namespace _4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ");
            Array.Reverse(input);
            foreach (string s in input)
                Console.Write(s + " ");
        }
    }
}

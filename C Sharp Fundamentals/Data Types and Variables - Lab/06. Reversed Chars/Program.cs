using System;

namespace _06._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[3];

            for (int i = 0; i < 3; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{chars[2]} {chars[1]} {chars[0]}");
        }
    }
}

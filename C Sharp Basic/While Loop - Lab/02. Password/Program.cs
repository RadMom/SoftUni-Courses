using System;

namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != password)
            { }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}

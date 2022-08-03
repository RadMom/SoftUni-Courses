using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int pieces = width * lenght;
            string input ;

            while (pieces >= 0 &&(input = Console.ReadLine()) != "STOP")
            {
                pieces -= int.Parse(input);
            }
            if (pieces < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
        }
    }
}

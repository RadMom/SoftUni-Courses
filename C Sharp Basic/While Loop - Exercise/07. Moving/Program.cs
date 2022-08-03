using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int volume = width * lenght * hight;
            string input="";

            while (volume >= 0 && (input = Console.ReadLine()) != "Done")
            {
                volume -= int.Parse(input);
            }
            if(input=="Done")
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
            else if(volume<=0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
        }
    }
}

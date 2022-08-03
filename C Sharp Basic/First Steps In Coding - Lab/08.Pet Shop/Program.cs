using System;

namespace Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double dogPricePerPack = 2.50;
            double catPricePerPack = 4;

            double totalPrice = dogFood * dogPricePerPack + catFood * catPricePerPack;

            Console.WriteLine($"{totalPrice} lv.");

        }
    }
}

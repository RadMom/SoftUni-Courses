using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int talkingdoll = int.Parse(Console.ReadLine());
            int teddybear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int toyTruck = int.Parse(Console.ReadLine());

            int counter = puzzle + talkingdoll + teddybear + minion + toyTruck;
            double total = puzzle * 2.60 + talkingdoll * 3 + teddybear * 4.10 + minion * 8.20 + toyTruck * 2;

            if (counter >= 50)
            {
                total *= 0.75;
            }
            total *= 0.9;
            if (total >= tripPrice)
            {
                Console.WriteLine($"Yes! {total - tripPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - total:f2} lv needed.");
            }
        }
    }
}

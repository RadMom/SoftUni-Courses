using System;

namespace _01._Christmas_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packingPaprer = int.Parse(Console.ReadLine());
            int fabricRolls = int.Parse(Console.ReadLine());
            double glueLitres = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double totalWithoutDiscount = packingPaprer * 5.80 + fabricRolls * 7.20 + glueLitres * 1.2;
            double totalWithDiscount = totalWithoutDiscount - (totalWithoutDiscount * discount / 100);

            Console.WriteLine($"{totalWithDiscount:f3}");
        }
    }
}

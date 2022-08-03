using System;

namespace _01._Fruit_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double strawberryPricePerKg = double.Parse(Console.ReadLine());
            double bananasKg=double.Parse(Console.ReadLine());
            double orangerKg = double.Parse(Console.ReadLine());
            double rasberriesKg = double.Parse(Console.ReadLine());
            double strawberryKg = double.Parse(Console.ReadLine());

            double rasberriesTotal = strawberryPricePerKg * 0.5 * rasberriesKg;
            double orangeTotal = (strawberryPricePerKg * 0.5) * 0.6*orangerKg;
            double bananaTotal = strawberryPricePerKg * 0.5 * 0.2*bananasKg;
            double strawberriesTotal = strawberryPricePerKg * strawberryKg;
            double total=rasberriesTotal+orangeTotal+bananaTotal+strawberriesTotal;

            Console.WriteLine($"{total:f2}");

        }
    }
}

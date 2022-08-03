using System;

namespace _05.Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pensPackages = int.Parse(Console.ReadLine());
            int markersPackeges = int.Parse(Console.ReadLine());
            int productInLitres = int.Parse(Console.ReadLine());
            int percentigeDiscountAsNum = int.Parse(Console.ReadLine());

            double pensPackagesPrice = pensPackages * 5.80;
            double markersPackegesPrice = markersPackeges * 7.20;
            double productInLitrePrice = productInLitres * 1.20;

            double priceBeforeDiscount = pensPackagesPrice + markersPackegesPrice + productInLitrePrice;
            double discount = percentigeDiscountAsNum / 100.00;

            double TotalWithDiscount = priceBeforeDiscount - (priceBeforeDiscount * discount);
            Console.WriteLine(TotalWithDiscount);
        }
    }
}

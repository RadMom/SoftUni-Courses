using System;

namespace Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m2ForGreening = double.Parse(Console.ReadLine());

            double pricePerM2 = 7.61;
            double discount = 0.18;

            double totalWithoutDiscount = m2ForGreening* pricePerM2;
            double totalDiscount = discount * totalWithoutDiscount;
            double total = totalWithoutDiscount - totalDiscount;

            Console.WriteLine($"The final price is: {total} lv.");
            Console.WriteLine($"The discount is: {totalDiscount} lv.");


        }
    }
}

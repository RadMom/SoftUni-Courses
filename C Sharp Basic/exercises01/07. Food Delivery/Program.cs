using System;

namespace _07.Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenuAmaunt = int.Parse(Console.ReadLine());
            int fishMenuAmaunt = int.Parse(Console.ReadLine());
            int veggieMenuAmaunt = int.Parse(Console.ReadLine());

            double chickenTotalAmaunt = chickenMenuAmaunt * 10.35;
            double fistTotalAmaunt = fishMenuAmaunt * 12.40;
            double veggieTotalAmaunt = veggieMenuAmaunt * 8.15;

            double totalMenu = chickenTotalAmaunt + fistTotalAmaunt + veggieTotalAmaunt;

            double dessert = 0.2 * totalMenu;
            double delivery = 2.50;

            double totalPrice = totalMenu + dessert + delivery;

            Console.WriteLine(totalPrice);
        }
    }
}

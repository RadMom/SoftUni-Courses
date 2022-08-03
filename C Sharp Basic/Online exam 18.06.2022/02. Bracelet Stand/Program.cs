using System;

namespace _02._Bracelet_Stand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pocketMoneyPerDay = double.Parse(Console.ReadLine());
            double moneyFromSellsPerDay = double.Parse(Console.ReadLine());
            double costsTotal=double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double totalSavedMoney = pocketMoneyPerDay * 5 + moneyFromSellsPerDay * 5 - costsTotal;

            if(totalSavedMoney>=giftPrice)
            {
                Console.WriteLine($"Profit: {totalSavedMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {giftPrice-totalSavedMoney:f2} BGN.");
            }
        }
    }
}

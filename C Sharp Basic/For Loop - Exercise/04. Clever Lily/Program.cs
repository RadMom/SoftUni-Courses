using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceLaundry=double.Parse(Console.ReadLine());
            int pricePerToy=int.Parse(Console.ReadLine());

            double savedMoney = 0;
            double savedMoneyTotal = 0;
            int numberToys = 0;
            int moneyForBrother = 0;

            for (int i=1; i<=age; i++)
            {
                
                if(i%2==0)
                {
                    savedMoney += 10;
                    savedMoneyTotal += savedMoney;
                    savedMoneyTotal--;
                }
                else
                {
                    numberToys++;
                }
            }

            double totalSavedMoney = (savedMoneyTotal - moneyForBrother)+(numberToys*pricePerToy);

            if(totalSavedMoney>=priceLaundry)
            {
                Console.WriteLine($"Yes! {(totalSavedMoney - priceLaundry):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceLaundry - totalSavedMoney):f2}");
            }
        }
    }
}

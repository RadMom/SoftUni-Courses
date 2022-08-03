using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            int spendingCounter = 0;
            int daysCounter = 0;

            while(ownedMoney<neededMoney)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;

                if(command=="spend")
                {
                    ownedMoney -= money;
                    spendingCounter++;

                    if(ownedMoney<0)
                    {
                        ownedMoney = 0;
                    }
                    if(spendingCounter==5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCounter);
                        return;
                    }
                }
                else if(command=="save")
                {
                    ownedMoney += money;
                    spendingCounter = 0;

                }
            }
            Console.WriteLine($"You saved the money for {daysCounter} days.");

        }
    }
}

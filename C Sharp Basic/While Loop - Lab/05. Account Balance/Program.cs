using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string payments = Console.ReadLine();

            double total = 0;

            while(payments != "NoMoreMoney")
            {
                double money = double.Parse(payments);

                if(money<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {money:f2}");
                    total += money;
                    payments = Console.ReadLine();
                }
            }
            Console.WriteLine($"Total: {total:f2}");

        }
    }
}

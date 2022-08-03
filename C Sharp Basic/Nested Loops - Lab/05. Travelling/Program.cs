using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                while (savedMoney < minBudget)
                {
                    double money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                }
                Console.WriteLine($"Going to {input}!");
            }
        }
    }
}

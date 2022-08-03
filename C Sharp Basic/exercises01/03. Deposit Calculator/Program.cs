using System;

namespace _03.Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = int.Parse(Console.ReadLine());
            int termOfTheDeposit = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());
            double annualInterestRateAsNumber = annualInterestRate / 100.00;
            double totalAmaunt = depositAmount + termOfTheDeposit * ((depositAmount * annualInterestRateAsNumber) / 12);

            Console.WriteLine(totalAmaunt);
        }
    }
}

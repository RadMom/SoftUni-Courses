using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;

            string input = "";

            while ((input = Console.ReadLine()) != "stop")
            {
                int num = int.Parse(input);
                int counter = 0;
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                if (num == 0 || num == 1)
                {
                    nonPrimeSum += num;
                }
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter > 1)
                {
                    nonPrimeSum += num;
                }
                else
                {
                    primeSum += num;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}

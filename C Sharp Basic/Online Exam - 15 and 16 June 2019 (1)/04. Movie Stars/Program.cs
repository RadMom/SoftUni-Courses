using System;

namespace _04._Movie_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string input = "";
            double total = 0;

            while((input=Console.ReadLine())!="ACTION")
            {
                int nameOfTheStar = input.Length;
                if(nameOfTheStar<=15)
                {
                    double salary = double.Parse(Console.ReadLine());
                    total += salary;
                }
                else
                {
                    total += (budget - total) * 0.2;
                }
                if(total>=budget)
                {
                    Console.WriteLine($"We need {total - budget:f2} leva for our actors.");
                    break;
                }
            }
            if(input=="ACTION")
            {
                Console.WriteLine($"We are left with {budget - total:f2} leva.");
            }
        }
    }
}

using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearDead = int.Parse(Console.ReadLine());

            int ivanchoYears = 18;

            for(int i=1800;i<=yearDead;i++)
            {
                if(i%2==0)
                {
                    inheritedMoney -= 12000;
                    ivanchoYears++;
                }
                else
                {
                    inheritedMoney -= 12000 + (ivanchoYears * 50);
                    ivanchoYears++;
                }
            }
            if(inheritedMoney>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree " +
                    $"life and will have {inheritedMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
            }
        }
    }
}

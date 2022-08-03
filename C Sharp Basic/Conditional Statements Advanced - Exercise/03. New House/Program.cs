using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget=int.Parse(Console.ReadLine());

            double cost = 0;

            if(flower=="Roses")
            {
                cost = numberOfFlowers *5.00 ;
                if(numberOfFlowers>80)
                {
                    cost *=0.90;
                }
            }
            else if (flower == "Dahlias")
            {
                cost = numberOfFlowers *3.80 ;
                if (numberOfFlowers>90)
                {
                    cost *=0.85;
                }
            }
            else if (flower == "Tulips")
            {
                cost = numberOfFlowers *2.80 ;
                if (numberOfFlowers>80)
                {
                    cost *=0.85;
                }
            }
            else if (flower == "Narcissus")
            {
                cost = numberOfFlowers *3.00 ;
                if (numberOfFlowers<120)
                {
                    cost *=1.15;
                }
            }
            else if (flower == "Gladiolus")
            {
                cost = numberOfFlowers *2.50 ;
                if (numberOfFlowers<80)
                {
                    cost *=1.20;
                }
            }
            if(cost<=budget)
            {
                Console.WriteLine($"Hey, you have a great garden with" +
                    $" {numberOfFlowers} {flower} and {(budget - cost):f2} leva left.");           
            }
            else if(cost>budget)
            {
                Console.WriteLine($"Not enough money, you need {(cost - budget):f2} leva more.");
            }
        }
    }
}

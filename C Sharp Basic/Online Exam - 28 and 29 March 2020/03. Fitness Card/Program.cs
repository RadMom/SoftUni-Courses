using System;

namespace _03._Fitness_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double total = 0;

            //Пол Gym	Boxing	Yoga	Zumba	Dances	Pilates
            //мъж $42    $41    $45     $34     $51     $39
            //жена $35    $37    $42     $31     $53     $37
            if (gender == "m")
            {
                if (sport == "Gym")
                {
                    total += 42;
                }
                else if (sport == "Boxing")
                {
                    total += 41;
                }
                else if (sport == "Yoga")
                {
                    total += 45;
                }
                else if (sport == "Zumba")
                {
                    total += 34;
                }
                else if (sport == "Dances")
                {
                    total += 51;
                }
                else if (sport == "Pilates")
                {
                    total += 39;
                }
            }
            else if (gender == "f")
            {
                if (sport == "Gym")
                {
                    total += 35;
                }
                else if (sport == "Boxing")
                {
                    total += 37;
                }
                else if (sport == "Yoga")
                {
                    total += 42;
                }
                else if (sport == "Zumba")
                {
                    total += 31;
                }
                else if (sport == "Dances")
                {
                    total += 53;
                }
                else if (sport == "Pilates")
                {
                    total += 37;
                }
            }
            if (age <= 19)
            {
                total *= 0.80;
            }
            if(amount>=total)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else if(amount<total)
            {
                Console.WriteLine($"You don't have enough money! You need ${total - amount:f2} more.");
            }
        }
    }
}

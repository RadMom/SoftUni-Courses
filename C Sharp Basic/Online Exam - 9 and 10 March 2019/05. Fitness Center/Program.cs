using System;

namespace _05._Fitness_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int backCounter = 0;
            int chestCounter = 0;
            int legsCounter = 0;
            int absCounter = 0;
            int proteinShakeCounter = 0;
            int proteinBarCounter = 0;
            double workOutCounter = 0;
            double proteinCounter = 0;
            
            for(int i=1;i<=people;i++ )
            {
                string activity=Console.ReadLine();
                                
                if (activity=="Back")
                {
                    backCounter++;
                    workOutCounter++;
                }
                if (activity == "Chest")
                {
                    chestCounter++;
                    workOutCounter++;
                }
                if (activity == "Legs")
                {
                    legsCounter++;
                    workOutCounter++;
                }
                if (activity == "Abs")
                {
                    absCounter++;
                    workOutCounter++;
                }
                if (activity == "Protein shake")
                {
                    proteinShakeCounter++;
                    proteinCounter++;
                }
                if (activity == "Protein bar")
                {
                    proteinBarCounter++;
                    proteinCounter++;
                }
            }
            Console.WriteLine($"{backCounter} - back");
            Console.WriteLine($"{chestCounter} - chest");
            Console.WriteLine($"{legsCounter} - legs");
            Console.WriteLine($"{absCounter} - abs");
            Console.WriteLine($"{proteinShakeCounter} - protein shake");
            Console.WriteLine($"{proteinBarCounter} - protein bar");
            Console.WriteLine($"{workOutCounter/people*100:f2}% - work out");
            Console.WriteLine($"{proteinCounter/people*100:f2}% - protein");
        }
    }
}

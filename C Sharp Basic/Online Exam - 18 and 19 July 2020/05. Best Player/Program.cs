using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int goals = 0;
            int hatTrick = 0;
            string bestPlayer = "";

            while (goals < 10 && (name = Console.ReadLine()) != "END")
            {
                int goals1 = int.Parse(Console.ReadLine());

                if (goals1 > goals)
                {
                    goals = goals1;
                    bestPlayer = name;
                    if (goals1 >= 3)
                    {
                        hatTrick++;
                    }
                    if (goals >= 10)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (hatTrick > 0)
            {
                Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goals} goals.");
            }
        }
    }
}

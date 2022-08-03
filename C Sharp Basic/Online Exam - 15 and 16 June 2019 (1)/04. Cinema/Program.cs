using System;

namespace _04._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seats = int.Parse(Console.ReadLine());

            string input = "";
            int counter = 0;

            int total = 0;

            while ((input = Console.ReadLine()) != "Movie time!")
            {
                int input1 = int.Parse(input);
                counter += input1;

                if (counter > seats)
                {
                    break;
                }
                if (input1 % 3 == 0)
                {
                    total += input1 * 5 - 5;
                }
                else
                {
                    total += input1 * 5;
                }
            }
            if (input == "Movie time!")
            {
                Console.WriteLine($"There are {seats - counter} seats left in the cinema.");
                Console.WriteLine($"Cinema income - {total } lv.");
            }
            if (counter > seats)
            {
                Console.WriteLine("The cinema is full.");
                Console.WriteLine($"Cinema income - {total} lv.");
            }

        }
    }
}

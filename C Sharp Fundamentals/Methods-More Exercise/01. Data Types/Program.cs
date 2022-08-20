using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DataType(input);
        }

        private static void DataType(string input)
        {
            if (input == "int")
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number * 2);
            }
            else if (input == "real")
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine($"{number * 1.5:f2}");
            }
            else if(input=="string")
            {
                string word = Console.ReadLine();
                Console.WriteLine($"${word}$");
            }
        }
    }
}

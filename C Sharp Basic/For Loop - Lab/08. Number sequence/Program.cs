using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            
            for(int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(number>maxNumber)
                {
                    maxNumber = number;
                }
                if(number<minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}

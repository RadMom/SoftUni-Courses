using System;

namespace _06._Substitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int num1Digit1 = k; num1Digit1 <= 8; num1Digit1++)
            {
                for (int num1Digit2 = 9; num1Digit2 >= l; num1Digit2--)
                {
                    for (int num2Digit1 = m; num2Digit1 <= 8; num2Digit1++)
                    {
                        for (int num2Digit2 = 9; num2Digit2 >= n; num2Digit2--)
                        {
                            if (num1Digit1 % 2 == 0 && num2Digit1 % 2 == 0
                                && num1Digit2 % 2 != 0 && num2Digit2 % 2 != 0)
                            {
                                if (num1Digit1 == num2Digit1 && num1Digit2 == num2Digit2)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine($"{num1Digit1}{num1Digit2}" +
                                        $" - {num2Digit1}{num2Digit2}");
                                    counter++;
                                }
                            }
                            if(counter>5)
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}

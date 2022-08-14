using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Matrix(number);
        }

        static void Matrix(int number)
        {
            for (int rows = 0; rows < number; rows++)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

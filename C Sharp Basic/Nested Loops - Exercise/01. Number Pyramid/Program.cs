using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int numsForPrint = 1; numsForPrint <= rows; numsForPrint++)
                {
                    Console.Write(counter + " ");
                    counter++;
                    if(counter>n)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

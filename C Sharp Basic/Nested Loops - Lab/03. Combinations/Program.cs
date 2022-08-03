using System;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int validCounter = 0;

            for (int i1 = 0; i1 <= n; i1++)
            {
                for (int i2 = 0; i2 <= n; i2++)
                {
                    for (int i3 = 0; i3 <= n; i3++)
                    {
                        if (i1 + i2 + i3 == n)
                        {
                            validCounter++;
                        }
                    }
                }
            }
            Console.WriteLine(validCounter);
        }
    }
}

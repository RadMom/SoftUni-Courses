﻿using System;

namespace _06._Barcode_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            int fourthStart = startNum % 10;
            int thirdStart = (startNum / 10) % 10;
            int secondStart = (startNum / 100) % 10;
            int firstStart = (startNum / 1000) % 10;

            int fourthEnd = endNum % 10;
            int thirdEnd = (endNum / 10) % 10; ;
            int secondEnd = (endNum / 100) % 10;
            int firstEnd = (endNum / 1000) % 10;

            for (int i = firstStart; i <= firstEnd; i++)
            {
                for (int j = secondStart; j <= secondEnd; j++)
                {
                    for (int k = thirdStart; k <= thirdEnd; k++)
                    {
                        for (int l = fourthStart; l <= fourthEnd; l++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}

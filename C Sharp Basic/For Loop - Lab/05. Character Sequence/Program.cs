﻿using System;

namespace _05._Character_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word=Console.ReadLine();

            for (int i=0; i<word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }

        }
    }
}

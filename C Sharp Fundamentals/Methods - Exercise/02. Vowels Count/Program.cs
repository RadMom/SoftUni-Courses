using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();

           SearchForVoweles(inputText);
        }

        private static void SearchForVoweles(string text)
        {
            Console.WriteLine(text.Count(vowels => "aouei".Contains(vowels)));
        }
    }
}

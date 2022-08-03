using System;

namespace _02._English_Name_of_the_Last_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int lastDigit = number % 10;
            string word = "";

            switch (lastDigit)
            {
                case 0: word = "zero"; break;
                case 1: word = "one"; break;
                case 2: word = "two"; break;
                case 3: word = "three"; break;
                case 4: word = "four"; break;
                case 5: word = "five"; break;
                case 6: word = "six"; break;
                case 7: word = "seven"; break;
                case 8: word = "eight"; break;
                case 9: word = "nine"; break;
            }
            Console.WriteLine(word);
        }
    }
}

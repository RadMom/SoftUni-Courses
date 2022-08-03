using System;

namespace _01._Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "";

            while ((text = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(text);
            }
        }
    }
}

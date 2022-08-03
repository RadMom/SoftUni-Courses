using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook=Console.ReadLine();
            int counter = 0;
            string nextBook;

            while((nextBook=Console.ReadLine()) != "No More Books")
            {
                if(nextBook==favoriteBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    return;
                }
                counter++;
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {counter} books.");
        }
    }
}

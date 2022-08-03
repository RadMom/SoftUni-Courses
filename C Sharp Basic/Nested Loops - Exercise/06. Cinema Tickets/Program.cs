using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalTickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidsTickets = 0;
            string movie = "";

            while ((movie = Console.ReadLine()) != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                string ticket = "";
                double counter = 0;

                while ((ticket=Console.ReadLine()) != "End")
                {
                    if (ticket == "student")
                    {
                        counter++;
                        totalTickets++;
                        studentTickets++;
                    }
                    else if (ticket == "standard")
                    {
                        counter++;
                        totalTickets++;
                        standardTickets++;
                    }
                    else if (ticket == "kid")
                    {
                        counter++;
                        totalTickets++;
                        kidsTickets++;
                    }
                    if(counter==freeSeats)
                    {
                        break;
                    }
                }
                Console.WriteLine($"{movie} - {counter / freeSeats * 100:f2}% full.");
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTickets / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardTickets / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidsTickets / totalTickets * 100:f2}% kids tickets.");
        }
    }
}

using System;

namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centures = int.Parse(Console.ReadLine());
            int years = centures * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes"
                , centures, years, days, hours, minutes);
        }
    }
}

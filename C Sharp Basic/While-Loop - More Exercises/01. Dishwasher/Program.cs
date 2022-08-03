using System;

namespace _01._Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottlesDetergent = int.Parse(Console.ReadLine());

            int totalDetergent = bottlesDetergent * 750;
            int counter = 0;
            int dishes = 0;
            int pots = 0;
            string input="";

            while(totalDetergent>=0 && (input=Console.ReadLine())!="End")
            {
                counter++;

                if(counter%3==0)
                {
                    pots += int.Parse(input);
                    totalDetergent -= int.Parse(input) * 15;
                }
                else
                {
                    dishes += int.Parse(input);
                    totalDetergent -= int.Parse(input) * 5;
                }
            }
            if(input=="End")
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {totalDetergent} ml.");
            }
            if(totalDetergent<0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(totalDetergent)} ml. more necessary!");
            }
        }
    }
}

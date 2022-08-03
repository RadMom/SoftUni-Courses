using System;

namespace Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cm = double.Parse(Console.ReadLine());

            double inch = 2.54;

            double resul = cm * inch;
            
            Console.WriteLine(resul);
        }
    }
}

using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            double powerNum = double.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(baseNum, powerNum));
        }

        static double RaiseToPower(double baseNum, double powerNum)
        {
            double result = 0;
            result = Math.Pow(baseNum, powerNum);
            return result;
        }
    }
}

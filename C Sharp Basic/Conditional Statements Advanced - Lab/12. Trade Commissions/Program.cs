using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commissions = 0;

            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commissions = sales * 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commissions = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commissions = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    commissions = sales * 0.12;
                }
            }
            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commissions = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commissions = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commissions = sales * 0.1;
                }
                else if (sales > 10000)
                {
                    commissions = sales * 0.13;
                }
            }
            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commissions = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commissions = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commissions = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    commissions = sales * 0.145;
                }
            }
            if (commissions > 0)
            {
                Console.WriteLine($"{commissions:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
                              
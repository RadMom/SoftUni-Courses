﻿using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 1; i <= openTabs; i++)
            {
                string site = Console.ReadLine();
                
                if(site=="Facebook")
                {
                    salary -= 150;
                }
                else if(site=="Instagram")
                {
                    salary -= 100;
                }
                else if(site=="Reddit")
                {
                    salary -= 50;
                }
                if (salary<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if(salary>0)
            {
                Console.WriteLine($"{salary}");
            }
        }
    }
}

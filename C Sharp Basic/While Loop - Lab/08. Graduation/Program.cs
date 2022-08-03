using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double totalGrades = 0;
            int curentClass = 1;
            int repeatedclass = 0;

            while(curentClass<=12)
            {
                double curentGrade=double.Parse(Console.ReadLine());
                if(curentGrade<4)
                {
                    repeatedclass++;
                   
                    if(repeatedclass>1)
                    {
                        Console.WriteLine($"{name} has been excluded at {curentClass} grade");
                        return;
                    }
                }
                else
                {
                    curentClass++;
                    totalGrades += curentGrade;
                }
            }
            Console.WriteLine($"{name} graduated. Average grade: {(totalGrades / 12):f2}");
        }
    }
}

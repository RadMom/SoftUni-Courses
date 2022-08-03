using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsNumber = int.Parse(Console.ReadLine());

            double totalGrades = 0;
            double topCounter = 0;
            double btw4And5Counter = 0;
            double btw3And4Counter = 0;
            double failedCounter = 0;


            for (int i = 1; i <= studentsNumber; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                totalGrades += grade;
                
                if (grade >= 5.00)
                {
                    topCounter++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    btw4And5Counter++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    btw3And4Counter++;
                }
                else if (grade < 3.00)
                {
                    failedCounter++;
                }
            }
            Console.WriteLine($"Top students: {topCounter / studentsNumber * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {btw4And5Counter / studentsNumber * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {btw3And4Counter / studentsNumber * 100:f2}%");
            Console.WriteLine($"Fail: {failedCounter / studentsNumber * 100:f2}%");
            Console.WriteLine($"Average: {totalGrades / studentsNumber:f2}");
        }
    }
}

using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryNumber = int.Parse(Console.ReadLine());

            double totalGrades = 0;
            int counterTotal = 0;
            string input = "";

            while ((input = Console.ReadLine()) != "Finish")
            {
                double sumGradesOfTheProject = 0;
                int gradesCouter = 0;
                for (int i = 1; i <= juryNumber; i++)
                {
                    double grades = double.Parse(Console.ReadLine());
                    totalGrades += grades;
                    gradesCouter++;
                    sumGradesOfTheProject += grades;
                    counterTotal++;
                }
                Console.WriteLine($"{input} - {sumGradesOfTheProject / gradesCouter:f2}.");
            }
            Console.WriteLine($"Student's final assessment is {totalGrades / counterTotal:f2}.");
        }
    }
}

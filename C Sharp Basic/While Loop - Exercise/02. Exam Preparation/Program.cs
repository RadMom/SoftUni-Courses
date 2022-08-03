using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badScores = int.Parse(Console.ReadLine());

            double scores = 0;
            int numberOfProblems = 0;
            
            string lastProblem = "";
            int badScoresCounter = 0;
            string problem;

            while((problem=Console.ReadLine())!="Enough")
            {
                lastProblem = problem;

                int grade = int.Parse(Console.ReadLine());

                if(grade<=4)
                {
                    badScoresCounter++;

                    if(badScoresCounter==badScores)
                    {
                        Console.WriteLine($"You need a break, {badScoresCounter} poor grades.");
                        return;
                    }
                }
                scores += grade;
                numberOfProblems++;
            }
            double averageScore = scores / numberOfProblems;
            Console.WriteLine($"Average score: {averageScore:f2}");
            Console.WriteLine($"Number of problems: {numberOfProblems}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
}

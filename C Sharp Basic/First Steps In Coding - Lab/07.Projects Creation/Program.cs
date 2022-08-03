using System;

namespace Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectsName = Console.ReadLine();
            int numberOfTheProjects = int.Parse(Console.ReadLine());

            int hoursPerProject = 3;
            
            int totalHours = numberOfTheProjects * hoursPerProject;

            Console.WriteLine($"The architect {architectsName} will need " +
                $"{totalHours} hours to complete {numberOfTheProjects} project/s.");

        }
    }
}

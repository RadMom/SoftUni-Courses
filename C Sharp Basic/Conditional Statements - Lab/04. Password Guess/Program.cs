using System;

namespace _04._Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass1 = Console.ReadLine();

            string pass2 = "s3cr3t!P@ssw0rd";

            if (pass1==pass2)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}

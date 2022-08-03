using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double lightSabersPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double total = (Math.Ceiling(countOfStudents * 1.10) * lightSabersPrice) +
                (countOfStudents * robePrice) + (countOfStudents * beltPrice - (countOfStudents / 6 * beltPrice));

            if (total <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - amountOfMoney:f2}lv more.");
            }
        }
    }
}

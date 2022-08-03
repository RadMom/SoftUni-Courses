using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int ariveHour = int.Parse(Console.ReadLine());
            int ariveMinutes = int.Parse(Console.ReadLine());

            int examInMinutes = examHour * 60 + examMinutes;
            int ariveInMinutes= ariveHour * 60 + ariveMinutes;
            int differenceInMinutes = examInMinutes - ariveInMinutes;

            if (ariveInMinutes > examInMinutes)
            {
                differenceInMinutes = Math.Abs(differenceInMinutes);

                if (differenceInMinutes > 59)
                {
                    int hours = differenceInMinutes / 60;
                    int minutes = differenceInMinutes % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{differenceInMinutes} minutes after the start");
                }
            }
            else if (differenceInMinutes >= 0 && differenceInMinutes <= 30)
            {
                if (differenceInMinutes == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{differenceInMinutes} minutes before the start");
                }
            }
            else if (differenceInMinutes > 30)
            {
                if (differenceInMinutes > 59)
                {
                    int hours = differenceInMinutes / 60;
                    int minutes = differenceInMinutes % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{differenceInMinutes} minutes before the start");
                }
            }
        }
    }
}

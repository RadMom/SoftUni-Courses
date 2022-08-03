using System;

namespace _06._Tournament_of_Christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double totalMoney = 0;
            int winCounter = 0;
            int lostCounter = 0;
            string input = "";

            for (int i = 1; i <= days; i++)
            {
                double winMoney = 0;
                int win = 0;
                int lose = 0;

                while ((input = Console.ReadLine()) != "Finish")
                {
                    if (input == "win")
                    {
                        win++;
                        winMoney += 20;
                    }
                    else if (input == "lose")
                    {
                        lose++;
                    }
                }
                if (win > lose)
                {
                    winMoney *= 1.10;
                    winCounter++;
                    totalMoney += winMoney;
                }
                else if (lose > win)
                {
                    totalMoney += winMoney;
                    lostCounter++;
                }
            }
            if (winCounter > lostCounter)
            {
                totalMoney *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else if (lostCounter > winCounter)
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}

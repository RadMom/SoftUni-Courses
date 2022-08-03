using System;

namespace _04._Game_Number_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerOne = Console.ReadLine();
            string playerTwo = Console.ReadLine();

            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End of game")
                {
                    Console.WriteLine($"{playerOne} has {firstPlayerPoints} points");
                    Console.WriteLine($"{playerTwo} has {secondPlayerPoints} points");
                    break;
                }
                int firstPlayerCard = int.Parse(input);
                int secondPlayerCard = int.Parse(Console.ReadLine());

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerPoints += firstPlayerCard - secondPlayerCard;
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    secondPlayerPoints += secondPlayerCard - firstPlayerCard;
                }
                else if (firstPlayerCard == secondPlayerCard)
                {
                    Console.WriteLine("Number wars!");
                    int NumWarsFirstPlayerCard = int.Parse(Console.ReadLine());
                    int numWarsSecondPlayerCard = int.Parse((Console.ReadLine()));

                    if (NumWarsFirstPlayerCard > numWarsSecondPlayerCard)
                    {
                        Console.WriteLine($"{playerOne} is winner with {firstPlayerPoints} points");
                    }
                    else if (numWarsSecondPlayerCard > NumWarsFirstPlayerCard)
                    {
                        Console.WriteLine($"{playerTwo} is winner with {secondPlayerPoints} points");
                    }
                    break;
                }
            }
        }
    }
}

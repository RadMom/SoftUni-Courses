using System;

namespace _03._Stream_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "";
            string letter = "";

            int c = 0;
            int o = 0;
            int n = 0;
            while ((letter = Console.ReadLine()) != "End")
            {
                char letter1 = char.Parse(letter);

                if (letter1 >= 'a' && letter1 <= 'z' || letter1 >= 'A' && letter1 <= 'Z')
                {
                    if (letter1 == 'c')
                    {
                        if (c == 0)
                        {
                            c++;

                        }
                    }
                    else if (letter1 == 'o')
                    {
                        if (o == 0)
                        {
                            o++;

                        }
                    }
                    else if (letter1 == 'n')
                    {
                        if (n == 0)
                        {
                            n++;

                        }
                    }
                    if (c > 0 && o > 0 && n > 0)
                    {
                        word += " ";
                        Console.WriteLine(word);
                        c = 0;
                        o = 0;
                        n = 0;
                        word = "";
                        continue;
                    }
                    else
                    {
                        word += letter1;

                    }
                }
            }

        }
    }
}

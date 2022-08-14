using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isPasswordLenghtValid = ValidatePasswordLenght(password);
            bool isPasswordContainsLettersAndDigits = ValidatePasswordText(password);
            bool isPasswordContainsTwoDigits = ValidatePasswordContainsDigits(password);
            if (!isPasswordLenghtValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswordContainsLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isPasswordContainsTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isPasswordContainsLettersAndDigits && isPasswordContainsTwoDigits && isPasswordLenghtValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ValidatePasswordContainsDigits(string password)
        {
            int count = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count >= 2;
        }

        static bool ValidatePasswordText(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        static bool ValidatePasswordLenght(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}

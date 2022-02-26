using System;

namespace T04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordValidator(password);
        }

        private static void PasswordValidator(string password)
        {
            bool isValid = true;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            foreach (var character in password)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid = false;
                    break;
                }
            }

            int digitsCount = 0;
            foreach (var character in password)
            {
                if (char.IsDigit(character))
                {
                    digitsCount++;
                }
            }

            if (digitsCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}

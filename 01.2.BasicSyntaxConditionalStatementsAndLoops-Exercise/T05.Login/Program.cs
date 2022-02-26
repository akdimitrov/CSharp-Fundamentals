using System;

namespace T05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int counter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    counter++;
                }
            }
        }
    }
}

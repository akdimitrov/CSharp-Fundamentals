using System;
using System.Text;

namespace T01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder password = new StringBuilder(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "TakeOdd")
                {
                    StringBuilder newPass = new StringBuilder();
                    for (int i = 1; i < password.Length; i += 2)
                    {
                        newPass.Append(password[i]);
                    }

                    password = newPass;
                }
                else if (tokens[0] == "Cut")
                {
                    password.Remove(int.Parse(tokens[1]), int.Parse(tokens[2]));
                }
                else if (tokens[0] == "Substitute")
                {
                    if (!password.ToString().Contains(tokens[1]))
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }

                    password.Replace(tokens[1], tokens[2]);
                }

                Console.WriteLine(password);
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}

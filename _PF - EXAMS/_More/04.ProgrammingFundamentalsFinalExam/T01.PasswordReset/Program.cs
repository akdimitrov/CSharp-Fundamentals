using System;
using System.Linq;
using System.Text;

namespace T01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder password = new StringBuilder(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] cmd = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmd[0];
                if (action == "TakeOdd")
                {
                    StringBuilder newPassword = new StringBuilder();
                    for (int i = 1; i < password.Length; i += 2)
                    {
                        newPassword.Append(password[i]);
                    }
                    password = newPassword;
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(cmd[1]);
                    int length = int.Parse(cmd[2]);
                    password.Remove(index, length);
                }
                else if (action == "Substitute")
                {
                    string substring = cmd[1];
                    string substitute = cmd[2];
                    if (password.ToString().Contains(substring))
                    {
                        password.Replace(substring, substitute);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }
                }

                Console.WriteLine(password);
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}

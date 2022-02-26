using System;

namespace T01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Decode")
            {
                string[] cmd = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                if (cmd[0] == "Move")
                {
                    int count = int.Parse(cmd[1]);
                    string substring = message.Substring(0, count);
                    message = message.Remove(0, count);
                    message += substring;
                }
                else if (cmd[0] == "Insert")
                {
                    int index = int.Parse(cmd[1]);
                    string value = cmd[2];
                    message = message.Insert(index, value);
                }
                else if (cmd[0] == "ChangeAll")
                {
                    string substring = cmd[1];
                    string replacement = cmd[2];
                    message = message.Replace(substring, replacement);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}

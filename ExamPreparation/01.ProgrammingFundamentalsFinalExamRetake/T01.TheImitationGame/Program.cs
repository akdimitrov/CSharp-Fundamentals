using System;
using System.Text;

namespace T01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "Decode")
            {
                string[] tokens = input.Split('|');
                if (tokens[0] == "Move")
                {
                    int count = int.Parse(tokens[1]);
                    message.Append(message.ToString(0, count)).Remove(0, count);
                }
                else if (tokens[0] == "Insert")
                {
                    message.Insert(int.Parse(tokens[1]), tokens[2]);
                }
                else if (tokens[0] == "ChangeAll")
                {
                    message.Replace(tokens[1], tokens[2]);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}

using System;
using System.Linq;
using System.Text;

namespace T01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder(Console.ReadLine());
            string commnad;
            while ((commnad = Console.ReadLine()) != "Reveal")
            {
                string[] tokens = commnad.Split(":|:");

                if (tokens[0] == "InsertSpace")
                {
                    message.Insert(int.Parse(tokens[1]), ' ');
                }
                else if (tokens[0] == "Reverse")
                {
                    string substring = tokens[1];
                    int index = message.ToString().IndexOf(substring);
                    if (index < 0)
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                    message.Remove(index, substring.Length);
                    message.Append(string.Join("", substring.Reverse()));
                }
                else if (tokens[0] == "ChangeAll")
                {
                    message.Replace(tokens[1], tokens[2]);
                }

                Console.WriteLine(message);
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}

using System;
using System.Linq;
using System.Text;

namespace T01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Reveal")
            {
                string[] cmd = input.Split(":|:");
                string action = cmd[0];
                if (action == "InsertSpace")
                {
                    int index = int.Parse(cmd[1]);
                    text = text.Insert(index, " ");
                }
                else if (action == "Reverse")
                {
                    string substring = cmd[1];
                    if (text.IndexOf(substring) != -1)
                    {
                        text = text.Remove(text.IndexOf(substring), substring.Length);
                        substring = string.Join("", substring.ToCharArray().Reverse());
                        text += substring;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (action == "ChangeAll")
                {
                    string substring = cmd[1];
                    string replacement = cmd[2];
                    text = text.Replace(substring, replacement);
                }

                Console.WriteLine(text);
                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {text}");
        }
    }
}

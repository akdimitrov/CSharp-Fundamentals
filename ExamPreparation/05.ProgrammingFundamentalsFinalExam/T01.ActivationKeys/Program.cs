using System;
using System.Text;

namespace T01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder key = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "Generate")
            {
                string[] tokens = command.Split(">>>");
                if (tokens[0] == "Contains")
                {
                    Console.WriteLine(key.ToString().Contains(tokens[1]) ?
                        $"{key} contains {tokens[1]}" : "Substring not found!");
                }
                else if (tokens[0] == "Flip")
                {
                    string upperLower = tokens[1];
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);
                    string substring = key.ToString(startIndex, endIndex - startIndex);
                    key.Replace(substring, upperLower == "Upper" ? substring.ToUpper() : substring.ToLower());
                    Console.WriteLine(key);
                }
                else if (tokens[0] == "Slice")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    key.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(key);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}

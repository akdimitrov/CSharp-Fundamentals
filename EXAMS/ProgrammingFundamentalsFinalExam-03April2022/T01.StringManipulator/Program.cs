using System;

namespace T01.StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmdArgs = input.Split();
                string cmdType = cmdArgs[0];

                if (cmdType == "Translate")
                {
                    char ch = char.Parse(cmdArgs[1]);
                    char replacement = char.Parse(cmdArgs[2]);
                    text = text.Replace(ch, replacement);
                    Console.WriteLine(text);
                }
                else if (cmdType == "Includes")
                {
                    string substring = cmdArgs[1];
                    Console.WriteLine(text.Contains(substring));
                }
                else if (cmdType == "Start")
                {
                    string substring = cmdArgs[1];
                    Console.WriteLine(text.StartsWith(substring));
                }
                else if (cmdType == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (cmdType == "FindIndex")
                {
                    char ch = char.Parse(cmdArgs[1]);
                    Console.WriteLine(text.LastIndexOf(ch));
                }
                else if (cmdType == "Remove")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int count = int.Parse(cmdArgs[2]);
                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }

                input = Console.ReadLine();
            }
        }
    }
}

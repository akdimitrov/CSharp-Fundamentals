using System;
using System.Linq;

namespace T01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Generate")
            {
                string[] cmd = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string action = cmd[0];
                if (action == "Contains")
                {
                    string substring = cmd[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string upperOrLower = cmd[1];
                    int startIndex = int.Parse(cmd[2]);
                    int endIndex = int.Parse(cmd[3]);
                    string substring = activationKey.Substring(startIndex, endIndex - startIndex);
                    activationKey = activationKey.Replace(substring, upperOrLower == "Upper" ? substring.ToUpper() : substring.ToLower());
                    Console.WriteLine(activationKey);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}

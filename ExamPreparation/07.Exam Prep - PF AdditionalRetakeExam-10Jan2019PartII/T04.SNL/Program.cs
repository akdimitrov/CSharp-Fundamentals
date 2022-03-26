using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.SNL
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> children = new Dictionary<string, int>();
            Dictionary<string, int> presents = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] info = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];
                if (name != "Remove")
                {
                    string toy = info[1];
                    int amount = int.Parse(info[2]);
                    if (!children.ContainsKey(name))
                    {
                        children[name] = 0;
                    }
                    children[name] += amount;

                    if (!presents.ContainsKey(toy))
                    {
                        presents[toy] = 0;
                    }
                    presents[toy] += amount;
                }
                else
                {
                    children.Remove(info[1]);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Children:");
            Console.WriteLine(string.Join(Environment.NewLine, children.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(x => $"{x.Key} -> {x.Value}")));
            Console.WriteLine("Presents:");
            Console.WriteLine(string.Join(Environment.NewLine, presents.Select(x => $"{x.Key} -> {x.Value}")));
        }
    }
}

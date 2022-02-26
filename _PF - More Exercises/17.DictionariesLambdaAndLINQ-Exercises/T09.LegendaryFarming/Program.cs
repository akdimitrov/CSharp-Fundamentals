using System;
using System.Collections.Generic;
using System.Linq;

namespace T09.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            { { "shards", 0 }, { "fragments", 0 }, { "motes", 0 } };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string obtainedMaterial = string.Empty;
            while (obtainedMaterial == string.Empty)
            {
                string[] input = Console.ReadLine().ToLower().Split();
                for (int i = 1; i < input.Length; i += 2)
                {
                    if (input[i] == "shards" || input[i] == "fragments" || input[i] == "motes")
                    {
                        keyMaterials[input[i]] += int.Parse(input[i - 1]);
                        if (keyMaterials[input[i]] >= 250)
                        {
                            keyMaterials[input[i]] -= 250;
                            obtainedMaterial = input[i];
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(input[i]))
                        {
                            junk[input[i]] = 0;
                        }
                        junk[input[i]] += int.Parse(input[i - 1]);
                    }
                }
            }

            string legendaryItem = string.Empty;
            switch (obtainedMaterial)
            {
                case "shards": legendaryItem = "Shadowmourne"; break;
                case "fragments": legendaryItem = "Valanyr"; break;
                case "motes": legendaryItem = "Dragonwrath"; break;
            }

            Console.WriteLine($"{legendaryItem} obtained!");
            Console.WriteLine($"{String.Join("\n", keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(x => $"{x.Key}: {x.Value}"))}");
            Console.WriteLine($"{String.Join("\n", junk.OrderBy(x => x.Key).Select(x => $"{x.Key}: {x.Value}"))}");
        }
    }
}

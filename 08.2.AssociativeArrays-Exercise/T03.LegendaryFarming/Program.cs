using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                ["shards"] = 0,
                ["motes"] = 0,
                ["fragments"] = 0
            };
            bool notObtained = true;
            while (notObtained)
            {
                string[] input = Console.ReadLine().ToLower().Split();
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];
                    if (!keyMaterials.ContainsKey(material))
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }
                        junkMaterials[material] += quantity;
                        continue;
                    }

                    keyMaterials[material] += quantity;
                    if (keyMaterials[material] >= 250)
                    {
                        keyMaterials[material] -= 250;
                        string item = String.Empty;
                        switch (material)
                        {
                            case "shards": item = "Shadowmourne"; break;
                            case "motes": item = "Dragonwrath"; break;
                            case "fragments": item = "Valanyr"; break;
                        }
                        Console.WriteLine($"{item} obtained!");
                        notObtained = false;
                        break;
                    }
                }
            }

            foreach (var pair in keyMaterials)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            foreach (var pair in junkMaterials)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}

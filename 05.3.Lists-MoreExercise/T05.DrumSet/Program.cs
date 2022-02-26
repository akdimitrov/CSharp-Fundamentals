using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());
            List<int> drums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> finalDrumsState = drums.ToList();
            string input;
            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int power = int.Parse(input);
                for (int i = 0; i < finalDrumsState.Count; i++)
                {
                    finalDrumsState[i] -= power;
                    if (finalDrumsState[i] <= 0)
                    {
                        if (drums[i] * 3 <= savings)
                        {
                            finalDrumsState[i] = drums[i];
                            savings -= drums[i] * 3;
                        }
                        else
                        {
                            drums.RemoveAt(i);
                            finalDrumsState.RemoveAt(i--);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", finalDrumsState));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}

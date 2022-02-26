using System;
using System.Linq;

namespace T02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random rnd = new Random();
            string[] randomized = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = rnd.Next(input.Length);
                while (randomized.Contains(input[randomIndex]))
                {
                    randomIndex = rnd.Next(input.Length);
                }
                randomized[i] = input[randomIndex];
            }

            foreach (var item in randomized)
            {
                Console.WriteLine(item);
            }
        }
    }
}

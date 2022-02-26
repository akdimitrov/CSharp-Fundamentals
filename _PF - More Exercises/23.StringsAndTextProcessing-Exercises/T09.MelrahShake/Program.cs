using System;

namespace T09.MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                int first = input.IndexOf(pattern);
                if (first != -1 && input.IndexOf(pattern, first + 1) != -1)
                {
                    input = input.Remove(first, pattern.Length);
                    input = input.Remove(input.LastIndexOf(pattern), pattern.Length);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    break;
                }
                pattern = pattern.Remove(pattern.Length / 2, 1);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}

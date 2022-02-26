using System;

namespace T01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int index = random.Next(words.Length);
                string temp = words[i];
                words[i] = words[index];
                words[index] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}

using System;

namespace T02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            string word1 = array[0];
            string word2 = array[1];
            Console.WriteLine(CharMultiplier(word1, word2));
        }

        private static int CharMultiplier(string word1, string word2)
        {
            int sum = 0;
            int lenght = Math.Max(word1.Length, word2.Length);
            for (int i = 0; i < lenght; i++)
            {
                if (i < word1.Length && i < word2.Length)
                {
                    sum += word1[i] * word2[i];
                    continue;
                }
                sum += word1.Length > word2.Length ? word1[i] : word2[i];
            }
            return sum;
        }
    }
}

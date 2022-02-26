using System;

namespace T04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(CharMultiplier(input[0], input[1]));
        }

        private static int CharMultiplier(string v1, string v2)
        {
            int result = 0;
            string logerString = v1.Length > v2.Length ? v1 : v2;
            for (int i = 0; i < Math.Max(v1.Length, v2.Length); i++)
            {
                result += i < v1.Length && i < v2.Length ? v1[i] * v2[i] : logerString[i];
            }

            return result;
        }
    }
}

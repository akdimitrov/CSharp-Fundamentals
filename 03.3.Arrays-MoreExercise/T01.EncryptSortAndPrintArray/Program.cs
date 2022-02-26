using System;
using System.Linq;

namespace T01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int vowelSum = 0;
                int consonantSum = 0;
                foreach (var letter in input)
                {
                    if ("aeiouAEIOU".Contains(letter))
                    {
                        vowelSum += letter * input.Length;
                    }
                    else
                    {
                        consonantSum += letter / input.Length;
                    }
                }
                array[i] = vowelSum + consonantSum;
            }

            Array.Sort(array);
            Console.WriteLine(String.Join("\n", array));
        }
    }
}

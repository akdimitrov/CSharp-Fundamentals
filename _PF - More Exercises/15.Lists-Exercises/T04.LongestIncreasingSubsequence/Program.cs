using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] length = new int[array.Length];
            int[] prev = new int[array.Length];
            int maxLength = 0;
            int maxLengthIndex = 0;

            for (int current = 0; current < array.Length; current++)
            {
                length[current] = 1;
                prev[current] = -1;

                for (int j = 0; j < current; j++)
                {
                    if (array[j] < array[current] && length[j] + 1 > length[current])
                    {
                        length[current] = length[j] + 1;
                        prev[current] = j;
                    }
                }

                if (length[current] > maxLength)
                {
                    maxLength = length[current];
                    maxLengthIndex = current;
                }
            }

            List<int> result = new List<int>();
            while (maxLengthIndex != -1)
            {
                result.Add(array[maxLengthIndex]);
                maxLengthIndex = prev[maxLengthIndex];
            }

            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

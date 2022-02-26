using System;
using System.Linq;

namespace T07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxCount = 0;
            int startIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    startIndex = i;
                }
            }

            for (int i = startIndex; i < startIndex + maxCount; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}

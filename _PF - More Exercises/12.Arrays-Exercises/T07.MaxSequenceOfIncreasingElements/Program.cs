using System;
using System.Linq;

namespace T07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxLength = 0;
            int startIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentLength = 0;
                int currentIndex = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j - 1] < array[j])
                    {
                        currentLength++;
                        if (currentLength == 1)
                        {
                            currentIndex = i;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    startIndex = currentIndex;
                }
            }

            for (int i = startIndex; i <= startIndex + maxLength; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}

using System;
using System.Linq;

namespace T06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxLength = 0;
            int startingIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int counter = 0;
                int index = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                        if (counter == 1)
                        {
                            index = i;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter > maxLength)
                {
                    maxLength = counter;
                    startingIndex = index;
                }
            }

            for (int i = startingIndex; i <= startingIndex + maxLength; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}

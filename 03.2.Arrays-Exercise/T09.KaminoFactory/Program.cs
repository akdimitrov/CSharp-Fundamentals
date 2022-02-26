using System;
using System.Linq;

namespace T09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] bestDna = new int[length];
            int bestDnaSampleNum = 0;
            int dnaSampleNum = 0;
            int maxLength = 0;
            int startingIndex = length;
            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                dnaSampleNum++;
                int currentStartingIndex = 0;
                int currentMaxLength = 0;
                int[] array = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int i = 0; i < length; i++)
                {
                    int counter = 1;
                    if (array[i] == 1)
                    {
                        for (int j = i + 1; j < length; j++)
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

                        if (counter > currentMaxLength)
                        {
                            currentMaxLength = counter;
                            currentStartingIndex = i;
                        }
                    }
                }

                if (currentMaxLength > maxLength)
                {
                    maxLength = currentMaxLength;
                    startingIndex = currentStartingIndex;
                    bestDnaSampleNum = dnaSampleNum;
                    Array.Copy(array, bestDna, length);
                }
                else if (currentMaxLength == maxLength)
                {
                    if (currentStartingIndex == startingIndex)
                    {
                        if (bestDna.Sum() < array.Sum())
                        {
                            Array.Copy(array, bestDna, length);
                            bestDnaSampleNum = dnaSampleNum;
                        }
                    }
                    else if (currentStartingIndex < startingIndex)
                    {
                        startingIndex = currentStartingIndex;
                        Array.Copy(array, bestDna, length);
                        bestDnaSampleNum = dnaSampleNum;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestDnaSampleNum} with sum: {bestDna.Sum()}.");
            Console.WriteLine(String.Join(" ", bestDna));
        }
    }
}

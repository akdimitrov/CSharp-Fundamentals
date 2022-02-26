using System;
using System.Linq;

namespace T08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counterMost = 0;
            int mostFrequentNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }

                if (counter > counterMost)
                {
                    counterMost = counter;
                    mostFrequentNumber = array[i];
                }
            }

            Console.WriteLine(mostFrequentNumber);
        }
    }
}

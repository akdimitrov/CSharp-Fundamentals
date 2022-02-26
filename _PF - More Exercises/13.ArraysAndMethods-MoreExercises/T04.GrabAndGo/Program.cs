using System;
using System.Linq;

namespace T04.GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int index = 0;
            long sum = 0;
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    index = i;
                    isFound = true;
                }
            }

            for (int i = 0; i < index; i++)
            {
                sum += array[i];
            }

            if (!isFound)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}

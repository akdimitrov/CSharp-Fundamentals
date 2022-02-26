using System;

namespace T03.LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;

            for (int i = 0; i < n; i++)
            {
                if (i < k)
                {
                    for (int j = 0; j < i; j++)
                    {
                        array[i] += array[j];
                    }
                }
                else
                {
                    for (int j = i - k; j < i; j++)
                    {
                        array[i] += array[j];
                    }
                }
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}

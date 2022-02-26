using System;
using System.Linq;

namespace T03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lenght = array.Length / 4;
            int[] arraySum = new int[array.Length / 2];

            for (int i = 0; i < arraySum.Length; i++)
            {
                if (i < lenght)
                {
                    arraySum[i] = array[lenght + i] + array[lenght - 1 - i];
                }
                else
                {
                    arraySum[i] = array[lenght + i] + array[array.Length - 1 + lenght - i];
                }
            }

            Console.WriteLine(string.Join(" ", arraySum));
        }
    }
}

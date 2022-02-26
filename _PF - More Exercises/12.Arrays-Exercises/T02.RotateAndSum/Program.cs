using System;
using System.Linq;

namespace T02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] arrayTemp = new int[array.Length];
            int[] arraySum = new int[array.Length];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (j == 0)
                    {
                        arrayTemp[j] = array[array.Length - 1];
                    }
                    else
                    {
                        arrayTemp[j] = array[j - 1];
                    }
                }

                for (int j = 0; j < array.Length; j++)
                {
                    arraySum[j] += arrayTemp[j];
                }

                array = arrayTemp.ToArray();
            }

            Console.WriteLine(string.Join(" ", arraySum));
        }
    }
}

using System;
using System.Linq;

namespace T07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] shortArray = array1.Length > array2.Length ? array2 : array1;
            int[] longArray = array1.Length > array2.Length ? array1 : array2;

            int[] arraySum = new int[longArray.Length];

            for (int i = 0; i < longArray.Length; i++)
            {
                int index = i;
                while (index >= shortArray.Length)
                {
                    index -= shortArray.Length;
                }
                arraySum[i] = longArray[i] + shortArray[index];
            }

            Console.WriteLine(string.Join(" ", arraySum));

        }
    }
}

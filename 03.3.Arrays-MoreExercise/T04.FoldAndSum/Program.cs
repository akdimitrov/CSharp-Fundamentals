using System;
using System.Linq;

namespace T04.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lenght = array.Length / 4;
            int[] left = array.Take(lenght).Reverse().ToArray();
            int[] right = array.Skip(lenght * 3).Take(lenght).Reverse().ToArray();
            int[] baseArray = array.Skip(lenght).Take(lenght * 2).ToArray();
            for (int i = 0; i < baseArray.Length; i++)
            {
                if (i < lenght)
                {
                    baseArray[i] += left[i];
                }
                else
                {
                    baseArray[i] += right[i - lenght];
                }
            }
            Console.WriteLine(String.Join(" ", baseArray));

        }
    }
}

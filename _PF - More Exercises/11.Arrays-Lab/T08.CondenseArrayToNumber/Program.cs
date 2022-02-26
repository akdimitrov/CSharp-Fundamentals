using System;
using System.Linq;

namespace T08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = array.Length;
            while (length > 1)
            {
                length--;
                int[] condensedArray = new int[length];
                for (int i = 0; i < length; i++)
                {
                    condensedArray[i] = array[i] + array[i + 1];
                }

                array = condensedArray;
            }

            Console.WriteLine(array[0]);
        }
    }
}

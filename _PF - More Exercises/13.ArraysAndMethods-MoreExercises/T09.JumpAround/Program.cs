using System;
using System.Linq;

namespace T09.JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int i = 0;
            while (true)
            {
                sum += array[i];
                if (i + array[i] < array.Length)
                {
                    i += array[i];
                }
                else if (i - array[i] >= 0)
                {
                    i -= array[i];
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}

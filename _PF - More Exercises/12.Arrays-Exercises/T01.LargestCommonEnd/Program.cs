using System;

namespace T01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();
            int length = Math.Min(array1.Length, array2.Length);
            int counterLeft = 0;
            int counterRight = 0;

            for (int i = 0; i < length; i++)
            {
                if (array1[i] == array2[i])
                {
                    counterLeft++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < length; i++)
            {
                if (array1[array1.Length - 1 - i] == array2[array2.Length - 1 - i])
                {
                    counterRight++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(counterLeft, counterRight));
        }
    }
}

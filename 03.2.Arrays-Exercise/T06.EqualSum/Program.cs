using System;
using System.Linq;

namespace T06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFound = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j < i)
                    {
                        leftSum += numbers[j];
                    }
                    else if (j > i)
                    {
                        rightSum += numbers[j];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}

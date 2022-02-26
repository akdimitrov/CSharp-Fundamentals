using System;
using System.Linq;
using System.Numerics;

namespace T02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long[] nums = Console.ReadLine().Split().Select(long.Parse).ToArray();
                if (nums[0] > nums[1])
                {
                    long num = Math.Abs(nums[0]);
                    long sum = 0;
                    while (num != 0)
                    {
                        sum += num % 10;
                        num /= 10;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    long num = Math.Abs(nums[1]);
                    long sum = 0;
                    while (num != 0)
                    {
                        sum += num % 10;
                        num /= 10;
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}

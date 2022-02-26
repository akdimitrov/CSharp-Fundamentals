using System;
using System.Linq;

namespace T03.TheAngryCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int index = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            long leftSum = 0;
            long rightSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (type == "cheap")
                {
                    if (i < index && array[i] < array[index])
                    {
                        leftSum += array[i];
                    }
                    else if (i > index && array[i] < array[index])
                    {
                        rightSum += array[i];
                    }
                }
                else if (type == "expensive")
                {
                    if (i < index && array[i] >= array[index])
                    {
                        leftSum += array[i];
                    }
                    else if (i > index && array[i] >= array[index])
                    {
                        rightSum += array[i];
                    }
                }
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }
    }
}

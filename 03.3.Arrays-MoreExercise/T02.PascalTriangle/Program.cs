using System;

namespace T02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 1; i <= n; i++)
            {
                int[] temp = new int[i];
                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || j == i - 1)
                    {
                        temp[j] = 1;
                    }
                    else
                    {
                        temp[j] = numbers[j - 1] + numbers[j];
                    }
                }
                numbers = temp;
                Console.WriteLine(String.Join(" ", temp));
            }
        }
    }
}

using System;

namespace T07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintNMatrix(n);
        }

        private static void PrintNMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}

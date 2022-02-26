using System;

namespace T04.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n + 1];
            bool[] isPrime = new bool[n + 1];
            string primeNums = "";

            for (int i = 0; i <= n; i++)
            {
                array[i] = i;
                isPrime[i] = true;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    isPrime[i] = false;
                }

                if (isPrime[i])
                {
                    primeNums += $"{array[i]} ";

                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] % i == 0 && isPrime[j] == true)
                        {
                            isPrime[j] = false;
                        }
                    }
                }
            }

            Console.WriteLine(primeNums);
        }
    }
}

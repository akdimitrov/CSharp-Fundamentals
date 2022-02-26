using System;

namespace T04.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int currentNum = 2; currentNum <= num; currentNum++)
            {
                bool isPrime = true;
                for (int i = 2; i < currentNum; i++)
                {
                    if (currentNum % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", currentNum, isPrime.ToString().ToLower());
            }
        }
    }
}

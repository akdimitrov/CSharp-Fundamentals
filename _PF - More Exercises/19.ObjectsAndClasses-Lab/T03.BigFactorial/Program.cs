using System;
using System.Numerics;

namespace T03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            for (int i = 2; i <= n; i++)
            {
                nFactorial *= i;
            }
            Console.WriteLine(nFactorial);
        }
    }
}

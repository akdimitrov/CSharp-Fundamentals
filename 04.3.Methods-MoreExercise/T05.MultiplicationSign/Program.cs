using System;

namespace T05.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int negativeCounter = 0;
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                if (num1 < 0)
                {
                    negativeCounter++;
                }
                if (num2 < 0)
                {
                    negativeCounter++;
                }
                if (num3 < 0)
                {
                    negativeCounter++;
                }

                Console.WriteLine(negativeCounter % 2 == 0 ? "positive" : "negative");
            }
        }
    }
}

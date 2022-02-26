using System;

namespace T04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string reversed = Reverse(num);
            Console.WriteLine(reversed);
        }

        private static string Reverse(string num)
        {
            string reversed = "";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                reversed += num[i];
            }

            return reversed;
        }
    }
}

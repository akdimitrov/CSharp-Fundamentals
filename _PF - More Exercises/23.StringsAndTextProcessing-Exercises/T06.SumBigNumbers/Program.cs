using System;
using System.Linq;
using System.Text;

namespace T06.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine().Reverse().ToArray();
            var num2 = Console.ReadLine().Reverse().ToArray();
            var longerNum = num1.Length > num2.Length ? num1 : num2;
            StringBuilder sum = new StringBuilder();
            int remainder = 0;
            for (int i = 0; i < longerNum.Length; i++)
            {
                if (i < num1.Length && i < num2.Length)
                {
                    int currentSum = int.Parse(num1[i].ToString()) + int.Parse(num2[i].ToString()) + remainder;
                    sum.Insert(0, currentSum % 10);
                    remainder = currentSum / 10;
                }
                else
                {
                    int currentSum = int.Parse(longerNum[i].ToString()) + remainder;
                    sum.Insert(0, currentSum % 10);
                    remainder = currentSum / 10;
                }
            }

            if (remainder > 0)
            {
                sum.Insert(0, remainder);
            }

            while (sum[0] == '0' && sum.Length > 1)
            {
                sum.Remove(0, 1);
            }
            Console.WriteLine(sum);
        }
    }
}

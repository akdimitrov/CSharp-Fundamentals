using System;

namespace T03.EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(LastDigitInWord(number));
        }

        private static string LastDigitInWord(long number)
        {
            string digit = "";
            switch (number % 10)
            {
                case 0: digit = "zero"; break;
                case 1: digit = "one"; break;
                case 2: digit = "two"; break;
                case 3: digit = "three"; break;
                case 4: digit = "four"; break;
                case 5: digit = "five"; break;
                case 6: digit = "six"; break;
                case 7: digit = "seven"; break;
                case 8: digit = "eight"; break;
                case 9: digit = "nine"; break;
            }

            return digit;
        }
    }
}

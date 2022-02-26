using System;

namespace T08.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            if (type == "int")
            {
                int max = GreaterValue(int.Parse(value1), int.Parse(value2));
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char max = GreaterValue(char.Parse(value1), char.Parse(value2));
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string max = GreaterValue(value1, value2);
                Console.WriteLine(max);
            }
        }

        static int GreaterValue(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char GreaterValue(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string GreaterValue(string a, string b)
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}

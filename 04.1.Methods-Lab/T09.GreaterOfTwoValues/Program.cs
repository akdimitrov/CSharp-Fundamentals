using System;

namespace T09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();
            switch (type)
            {
                case "int": GetMax(int.Parse(value1), int.Parse(value2)); break;
                case "char": GetMax(char.Parse(value1), char.Parse(value2)); break;
                case "string": GetMax(value1, value2); break;
            }
        }

        private static void GetMax(int v1, int v2)
        {
            Console.WriteLine(v1 > v2 ? v1 : v2);
        }

        private static void GetMax(char v1, char v2)
        {
            Console.WriteLine(v1 > v2 ? v1 : v2);
        }

        private static void GetMax(string v1, string v2)
        {
            Console.WriteLine(v1.CompareTo(v2) > 0 ? v1 : v2);
        }
    }
}

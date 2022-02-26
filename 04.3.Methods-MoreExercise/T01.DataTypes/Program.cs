using System;

namespace T01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int num = int.Parse(Console.ReadLine());
                ProcessInputByType(num);
            }
            else if (type == "real")
            {
                double num = double.Parse(Console.ReadLine());
                ProcessInputByType(num);
            }
            else if (type == "string")
            {
                string text = Console.ReadLine();
                ProcessInputByType(text);
            }
        }

        static void ProcessInputByType(int num)
        {
            Console.WriteLine(num * 2);
        }

        static void ProcessInputByType(double num)
        {
            Console.WriteLine($"{num * 1.5:f2}");
        }

        static void ProcessInputByType(string text)
        {
            Console.WriteLine($"${text}$");
        }
    }
}

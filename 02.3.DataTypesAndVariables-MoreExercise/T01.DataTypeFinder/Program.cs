using System;

namespace T01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                int num; bool isInt = int.TryParse(input, out num);
                double real; bool isDouble = double.TryParse(input, out real);
                char ch; bool isChar = char.TryParse(input, out ch);
                bool boolean; bool isBool = bool.TryParse(input, out boolean);
                string type = string.Empty;
                if (isInt)
                {
                    type = "integer";
                }
                else if (isDouble)
                {
                    type = "floating point";
                }
                else if (isChar)
                {
                    type = "character";
                }
                else if (isBool)
                {
                    type = "boolean";
                }
                else
                {
                    type = "string";
                }
                Console.WriteLine($"{input} is {type} type");
                input = Console.ReadLine();
            }
        }
    }
}

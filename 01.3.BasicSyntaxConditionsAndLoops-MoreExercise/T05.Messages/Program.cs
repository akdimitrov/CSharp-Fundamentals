using System;

namespace T05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                int digit = input % 10;
                char symbol = ' ';
                switch (digit)
                {
                    case 0: symbol = ' '; break;
                    case 2: symbol = 'a'; break;
                    case 3: symbol = 'd'; break;
                    case 4: symbol = 'g'; break;
                    case 5: symbol = 'j'; break;
                    case 6: symbol = 'm'; break;
                    case 7: symbol = 'p'; break;
                    case 8: symbol = 't'; break;
                    case 9: symbol = 'w'; break;
                }
                symbol += (char)(input.ToString().Length - 1);
                message += symbol;
            }

            Console.WriteLine(message);
        }
    }
}

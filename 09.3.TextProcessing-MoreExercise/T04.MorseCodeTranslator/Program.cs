using System;
using System.Collections.Generic;
using System.Text;

namespace T04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseCode = new Dictionary<string, char>()
            {
                {".-",'A'}, {"-...",'B'}, {"-.-.",'C'}, {"-..",'D'}, {".",'E'},
                {"..-.",'F'}, {"--.",'G'}, {"....",'H'}, {"..",'I'}, {".---",'J'},
                {"-.-",'K'}, {".-..",'L'}, {"--",'M'}, {"-.",'N'}, {"---",'O'},
                {".--.",'P'}, {"--.-",'Q'}, {".-.",'R'}, {"...",'S'}, {"-",'T'},
                {"..-",'U'}, {"...-",'V'}, {".--",'W'}, {"-..-",'X'}, {"-.--",'Y'},
                {"--..",'Z'}, {"|",' '},
            };
            string[] morse = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder message = new StringBuilder();
            foreach (var item in morse)
            {
                message.Append(morseCode[item]);
            }
            Console.WriteLine(message);
        }
    }
}

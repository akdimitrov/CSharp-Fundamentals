using System;

namespace T01.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int nameIndex = input.IndexOf('@') + 1;
                int nameLenght = input.IndexOf('|') - nameIndex;
                string name = input.Substring(nameIndex, nameLenght);
                int ageIndex = input.IndexOf('#') + 1;
                int ageLenght = input.IndexOf('*') - ageIndex;
                string age = input.Substring(ageIndex, ageLenght);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}

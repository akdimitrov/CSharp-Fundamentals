using System;
using System.Collections.Generic;

namespace T04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "stop")
            {
                string email = Console.ReadLine();
                string domain = email.Split(".")[1];
                if (domain != "uk" && domain != "us")
                {
                    emails[input] = email;
                }

                input = Console.ReadLine();
            }

            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

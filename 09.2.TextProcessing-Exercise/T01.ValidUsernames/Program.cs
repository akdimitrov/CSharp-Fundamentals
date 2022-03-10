using System;
using System.Linq;

namespace T01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            Console.WriteLine(string.Join(Environment.NewLine, usernames.Where(x => IsUserNameValid(x))));
        }

        static bool IsUserNameValid(string username)
        {
            return username.Length >= 3 && username.Length <= 16 &&
                !username.Any(x => !char.IsLetterOrDigit(x) && x != '-' && x != '_');
        }
    }
}

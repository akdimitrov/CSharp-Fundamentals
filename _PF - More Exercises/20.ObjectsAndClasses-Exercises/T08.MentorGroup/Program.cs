using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace T08.MentorGroup
{
    class User
    {
        public User(string name)
        {
            Name = name;
            Entries = new List<DateTime>();
            Comments = new List<string>();
        }
        public string Name { get; set; }

        public List<DateTime> Entries { get; set; }

        public List<string> Comments { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            string input = Console.ReadLine();
            while (input != "end of dates")
            {
                string[] array = input.Split(' ', ',');
                string name = array[0];
                List<DateTime> dates = new List<DateTime>();
                for (int i = 1; i < array.Length; i++)
                {
                    dates.Add(DateTime.ParseExact(array[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                if (users.Any(user => user.Name == name))
                {
                    var userToUpdate = users.First(user => user.Name == name);
                    userToUpdate.Entries.AddRange(dates);
                }
                else
                {
                    User user = new User(name);
                    user.Entries.AddRange(dates);
                    users.Add(user);
                }

                input = Console.ReadLine();
            }

            string input2 = Console.ReadLine();
            while (input2 != "end of comments")
            {
                string[] userComment = input2.Split('-');
                string userName = userComment[0];
                string comment = userComment[1];
                if (users.Any(user => user.Name == userName))
                {
                    var userToUpdate = users.First(user => user.Name == userName);
                    userToUpdate.Comments.Add(comment);
                }

                input2 = Console.ReadLine();
            }

            foreach (var user in users.OrderBy(n => n.Name))
            {
                Console.WriteLine(user.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in user.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in user.Entries.OrderBy(d => d.Date))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
}

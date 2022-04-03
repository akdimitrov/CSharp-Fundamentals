using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.MessagesManager
{
    class User
    {
        private int messagesCapacity;

        public User(string username, int messagesCapacity, int sentMessages, int receivedMessages)
        {
            Username = username;
            this.messagesCapacity = messagesCapacity;
            SentMessages = sentMessages;
            ReceivedMessages = receivedMessages;
        }

        public string Username { get; set; }

        public int SentMessages { get; set; }

        public int ReceivedMessages { get; set; }

        public int TotalMessages => SentMessages + ReceivedMessages;

        public bool SendMessage()
        {
            SentMessages++;
            if (TotalMessages >= messagesCapacity)
            {
                Console.WriteLine($"{Username} reached the capacity!");
                return false;
            }

            return true;
        }

        public bool ReceiveMessage()
        {
            ReceivedMessages++;
            if (TotalMessages >= messagesCapacity)
            {
                Console.WriteLine($"{Username} reached the capacity!");
                return false;
            }

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            int capacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] cmdArgs = input.Split('=');
                string cmd = cmdArgs[0];

                if (cmd == "Add")
                {
                    string username = cmdArgs[1];
                    int sent = int.Parse(cmdArgs[2]);
                    int received = int.Parse(cmdArgs[3]);

                    if (!users.Any(x => x.Username == username))
                    {
                        users.Add(new User(username, capacity, sent, received));
                    }
                }
                else if (cmd == "Message")
                {
                    string sender = cmdArgs[1];
                    string receiver = cmdArgs[2];

                    if (users.Any(x => x.Username == sender) && users.Any(x => x.Username == receiver))
                    {
                        if (!users.FirstOrDefault(x => x.Username == sender).SendMessage())
                        {
                            users.Remove(users.FirstOrDefault(x => x.Username == sender));
                        }

                        if (!users.FirstOrDefault(x => x.Username == receiver).ReceiveMessage())
                        {
                            users.Remove(users.FirstOrDefault(x => x.Username == receiver));
                        }
                    }
                }
                else if (cmd == "Empty")
                {
                    string username = cmdArgs[1];
                    if (username == "All")
                    {
                        users.Clear();
                    }
                    else
                    {
                        users.Remove(users.FirstOrDefault(x => x.Username == username));
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Username} - {user.TotalMessages}");
            }
        }
    }
}

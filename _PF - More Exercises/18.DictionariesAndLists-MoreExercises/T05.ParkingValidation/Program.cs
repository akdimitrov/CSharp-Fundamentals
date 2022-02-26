using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingUsers = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string username = input[1];
                if (command == "register")
                {
                    string licensePlate = input[2];
                    bool isValid = licensePlate.Length == 8 &&
                        licensePlate.Substring(0, 2).All(char.IsUpper) &&
                        licensePlate.Substring(6, 2).All(char.IsUpper) &&
                        licensePlate.Substring(2, 4).All(char.IsDigit);
                    if (!parkingUsers.ContainsKey(username))
                    {
                        if (isValid)
                        {
                            if (!parkingUsers.ContainsValue(licensePlate))
                            {
                                parkingUsers[username] = licensePlate;
                                Console.WriteLine($"{username} registered {licensePlate} successfully");
                            }
                            else
                            {
                                Console.WriteLine($"ERROR: license plate {licensePlate} is busy");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: invalid license plate {licensePlate}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingUsers[username]}");
                    }
                }
                else
                {
                    if (parkingUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"user {username} unregistered successfully");
                        parkingUsers.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            Console.WriteLine(String.Join("\n", parkingUsers.Select(x => $"{x.Key} => {x.Value}")));
        }
    }
}

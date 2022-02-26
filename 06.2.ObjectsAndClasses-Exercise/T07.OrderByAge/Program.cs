using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.OrderByAge
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] info = input.Split();
                string name = info[0];
                string id = info[1];
                int age = int.Parse(info[2]);
                var personToUpdate = people.FirstOrDefault(x => x.ID == id);
                if (personToUpdate != null)
                {
                    personToUpdate.Age = age;
                    personToUpdate.Name = name;
                }
                else
                {
                    people.Add(new Person(name, id, age));
                }

                input = Console.ReadLine();
            }

            foreach (var person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.OrderByAge
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
                string[] array = input.Split();
                string name = array[0];
                string id = array[1];
                int age = int.Parse(array[2]);
                Person person = new Person(name, id, age);
                people.Add(person);

                input = Console.ReadLine();
            }

            foreach (var person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}

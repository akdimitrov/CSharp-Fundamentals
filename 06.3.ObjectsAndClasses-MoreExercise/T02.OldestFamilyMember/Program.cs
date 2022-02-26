using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.OldestFamilyMember
{
    class Person
    {
        public Person(string name, double age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public double Age { get; set; }
    }

    class Family
    {
        public Family()
        {
            Members = new List<Person>();
        }

        public List<Person> Members { get; set; }

        public void AddMember(Person person)
        {
            Members.Add(person);
        }

        public Person GetOldestPerson()
        {
            return Members.OrderByDescending(x => x.Age).First();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                double age = double.Parse(info[1]);
                family.AddMember(new Person(name, age));
            }

            Person oldestPerson = family.GetOldestPerson();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}

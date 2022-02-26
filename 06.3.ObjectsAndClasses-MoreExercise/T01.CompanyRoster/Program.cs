using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.CompanyRoster
{
    class Department
    {
        public Department(string departmentName)
        {
            Name = departmentName;
            Employees = new List<Employee>();
        }

        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }

    class Employee
    {
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }

        public decimal Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string employeeName = info[0];
                decimal salary = decimal.Parse(info[1]);
                string departmentName = info[2];
                Employee employee = new Employee(employeeName, salary);
                var department = departments.FirstOrDefault(x => x.Name == departmentName);
                if (department == null)
                {
                    Department newDepartment = new Department(departmentName);
                    newDepartment.Employees.Add(employee);
                    departments.Add(newDepartment);
                }
                else
                {
                    department.Employees.Add(employee);
                }
            }

            var highestAverageSalaryDepartment = departments.OrderByDescending(x => x.Employees.Average(x => x.Salary)).First();
            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment.Name}");
            foreach (var employee in highestAverageSalaryDepartment.Employees.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
}

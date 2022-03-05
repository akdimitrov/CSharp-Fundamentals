using System;
using System.Collections.Generic;

namespace T08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] info = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string company = info[0];
                string employeeId = info[1];
                if (!companies.ContainsKey(company))
                {
                    companies[company] = new List<string>();
                }
                if (!companies[company].Contains(employeeId))
                {
                    companies[company].Add(employeeId);
                }

                input = Console.ReadLine();
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}

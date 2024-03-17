using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> companies = new Dictionary<string, HashSet<string>>();

            string input;


            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" -> ");
                string companyName = tokens[0];
                string employeeId = tokens[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new HashSet<string>();
                }

                companies[companyName].Add(employeeId);
            }



            foreach (var company in companies.OrderBy(c => c.Key))
            {

                Console.WriteLine(company.Key);
                foreach (var employeeId in company.Value)
                {
                    Console.WriteLine("-- " + employeeId);
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment

{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating 10 new Employees
            Employee employee1 = new Employee() { FirstName = "Joe", LastName = "Smith", ID = 1 };
            Employee employee2 = new Employee() { FirstName = "Joe", LastName = "Shmoe", ID = 2 };
            Employee employee3 = new Employee() { FirstName = "Jeff", LastName = "Deff", ID = 3 };
            Employee employee4 = new Employee() { FirstName = "Brian", LastName = "Johnson", ID = 4 };
            Employee employee5 = new Employee() { FirstName = "Jenna", LastName = "Smith", ID = 5 };
            Employee employee6 = new Employee() { FirstName = "Frankie", LastName = "Suarez", ID = 6 };
            Employee employee7 = new Employee() { FirstName = "Joe", LastName = "Brown", ID = 7 };
            Employee employee8 = new Employee() { FirstName = "Theresa", LastName = "David", ID = 8 };
            Employee employee9 = new Employee() { FirstName = "Nancy", LastName = "Williams", ID = 9 };
            Employee employee10 = new Employee() { FirstName = "George", LastName = "Bush", ID = 10 };

            // Adding employees to list
            List<Employee> employees = new List<Employee>()
            {
                employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10
            };

            // foreach loop to find all named "Joe"
            Console.WriteLine("for each loop to find Joes:");

            foreach (Employee worker in employees)
            {
                if (worker.FirstName == "Joe")
                {
                    List<Employee> findJoe = new List<Employee>() { worker };
                    Console.WriteLine("\n-First Name: \"" + worker.FirstName + "\" -Last Name: \"" + worker.LastName + "\" -ID: \"" + worker.ID + "\"");
                }
            }

            // Lambda to find all named "Joe" and add them to list
            Console.WriteLine("lamda expression to find Joes:");

            List<Employee> findJoe2 = employees.Where(x => x.FirstName == "Joe").ToList();

            // Prints them to screen
            foreach (Employee joe in findJoe2)
            {
                Console.WriteLine("\n-First Name: \"" + joe.FirstName + "\" -Last Name: \"" + joe.LastName + "\" -ID: \"" + joe.ID + "\"");
            }

            // Lambda to find all IDs greater than 5
            Console.WriteLine("All employees with ID greater than 5:");

            List<Employee> IDs = employees.Where(x => x.ID > 5).ToList();

            // Prints them to screen
            foreach (Employee id in IDs)
            {
                Console.WriteLine("\n-First Name: \"" + id.FirstName + "\" -Last Name: \"" + id.LastName + "\" -ID: \"" + id.ID + "\"");
            }

            Console.ReadLine();
        }
    }
}

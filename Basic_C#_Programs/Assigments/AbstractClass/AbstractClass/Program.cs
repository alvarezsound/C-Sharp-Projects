using System;
using System.Collections.Generic;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeObject = new Employee<string>(); // instantiate an object from Employee class
            employeeObject.FirstName = "Sample"; // add value to string property inherited from Person Class
            employeeObject.LastName = "Student"; // add value to string property inherited from Person Class
            employeeObject.ID = 14;
            employeeObject.SayName(); // call superclass method

            Employee<string> employeeObject2 = new Employee<string>();
            employeeObject2.FirstName = "Test"; // add value to string property inherited from Person Class
            employeeObject2.LastName = "Student"; // add value to string property inherited from Person Class
            employeeObject2.ID = 33;
            employeeObject2.SayName(); // call superclass method


            List<string> employeeObject3 = new List<string>() // Assign list of strings to Things
            {
                "Jim", "Bob", "Sally", "Tom"
            };

            List<int> employeeObject4 = new List<int>() // Assign list of ints to Things
            {
                1, 2, 3, 4, 5, 6
            };

            foreach (var x in employeeObject3) // loop that prints all string things to console
            {
                Console.WriteLine(x);
            }
            foreach (var y in employeeObject4) // loop that prints all int things to console
            {
                Console.WriteLine(y);
            }

            Console.WriteLine("Do the two employees have the same ID?");
            Console.WriteLine(employeeObject.ID == employeeObject2.ID); // compare the two employee objects by ID

            employeeObject.Quit(); // call quit method which is inherited from the IQuittable interface
            Console.ReadLine();
        }
    }
}

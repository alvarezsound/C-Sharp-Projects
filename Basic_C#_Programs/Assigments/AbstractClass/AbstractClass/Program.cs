using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeObject = new Employee(); // instantiate an object from Employee class
            employeeObject.FirstName = "Sample"; // add value to string property inherited from Person Class
            employeeObject.LastName = "Student"; // add value to string property inherited from Person Class
            employeeObject.ID = 14;
            employeeObject.SayName(); // call superclass method

            Employee employeeObject2 = new Employee();
            employeeObject2.FirstName = "Test"; // add value to string property inherited from Person Class
            employeeObject2.LastName = "Student"; // add value to string property inherited from Person Class
            employeeObject2.ID = 33;
            employeeObject2.SayName(); // call superclass method

            Console.WriteLine("Do the two employees have the same ID?");
            Console.WriteLine(employeeObject.ID == employeeObject2.ID); // compare the two employee objects by ID

            employeeObject.Quit(); // call quit method which is inherited from the IQuittable interface
            Console.ReadLine();
        }
    }
}

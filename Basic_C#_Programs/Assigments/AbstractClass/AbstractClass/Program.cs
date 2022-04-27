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
            employeeObject.SayName(); // call superclass method
            Console.ReadLine();
        }
    }
}

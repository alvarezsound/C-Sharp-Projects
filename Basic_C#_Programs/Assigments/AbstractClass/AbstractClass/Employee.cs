using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person, IQuittable // inherits from Person Class and IQuittable interface
    {
        public int ID { get; set; }
        public override void SayName() // implement the SayName method from Person class
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit() // inherited from IQuittable
        {
            Console.WriteLine("The Program will now quit...");
            Environment.Exit(0);
        }
        public static bool operator ==(Employee employeeObject, Employee employeeObject2)
        {
           return employeeObject.ID == employeeObject2.ID; // overloading == operator
        }
        public static bool operator !=(Employee employeeObject, Employee employeeObject2)
        {
            return employeeObject.ID != employeeObject2.ID; // overloading != operator
        }
    }
}

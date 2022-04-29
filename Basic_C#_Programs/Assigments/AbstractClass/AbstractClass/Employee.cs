using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee<T> : Person, IQuittable // inherits from Person Class and IQuittable interface
    {
        public int ID { get; set; }
        public List<T> Things { get; set; } // List property with generic data type
        public override void SayName() // implement the SayName method from Person class
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit() // inherited from IQuittable
        {
            Console.WriteLine("The Program will now quit...");
            Environment.Exit(0);
        }
        public static bool operator ==(Employee<T> employeeObject, Employee<T> employeeObject2)
        {
           return employeeObject.ID == employeeObject2.ID; // overloading == operator
        }
        public static bool operator !=(Employee<T> employeeObject, Employee<T> employeeObject2)
        {
            return employeeObject.ID != employeeObject2.ID; // overloading != operator
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person, IQuittable // inherits from Person Class and IQuittable interface
    {
        public override void SayName() // implement the SayName method from Person class
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("The Program will now quit...");
            Environment.Exit(0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person // inherits from Person Class
    {
        public override void SayName() // implement the SayName method from Person class
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}

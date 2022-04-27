using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        public string FirstName { get; set; } // add a string property
        public string LastName { get; set; } // add a string property

        public void SayName() // method
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Person
    {
        public string FirstName { get; set; } // add a string property
        public string LastName { get; set; } // add a string property

        public abstract void SayName(); // add SayName method
    }
}

using System;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello, ";
            string fName = "Jeff ";
            string lName = "Alvarez";
            string all = greeting + fName + lName;
            Console.WriteLine(all.ToUpper());

        }
    }
}

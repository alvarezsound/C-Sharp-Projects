using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine(); //user inputs a number as a string
            int age = Convert.ToInt32(ageInput); //converts the string to integer
            Console.WriteLine("True or false. Have you ever had a DUI?");
            string duiInput = Console.ReadLine(); //user inputs true or false as a string
            bool dui = Convert.ToBoolean(duiInput); //converts string to boolean
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsInput = Console.ReadLine(); //user inputs a number as a string
            int tickets = Convert.ToInt32(ticketsInput); //converts the string to integer
            Console.WriteLine("Qualified?");
            bool result = age > 15 && dui == false && tickets <= 3; //compares needed values to be true
            Console.WriteLine(result); //displays result to console
        }
    }
}

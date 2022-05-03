using System;

namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            string hourlyRateOne = Console.ReadLine(); //user inputs a number as a string
            int rateOne = Convert.ToInt32(hourlyRateOne); //converts the string to integer for math
            Console.WriteLine("Hours worked per week?");
            string hoursWorkedOne = Console.ReadLine(); //user inputs a number as a string
            int hoursOne = Convert.ToInt32(hoursWorkedOne); //converts the string to integer for math
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string hourlyRateTwo = Console.ReadLine(); //user inputs a number as a string
            int rateTwo = Convert.ToInt32(hourlyRateTwo); //converts the string to integer for math
            Console.WriteLine("Hours worked per week?");
            string hoursWorkedTwo = Console.ReadLine(); //user inputs a number as a string
            int hoursTwo = Convert.ToInt32(hoursWorkedTwo); //converts the string to integer for math
            Console.WriteLine("Annual salary of Person 1:");
            int salaryOne = rateOne * hoursOne * 52; //calculates salary based on users inputs for person 1
            Console.WriteLine(salaryOne); //displays result from above calculation to console
            Console.WriteLine("Annual salary of Person 2:");
            int salaryTwo = rateTwo * hoursTwo * 52; //calculates salary based on users inputs for person 1
            Console.WriteLine(salaryTwo); //displays result from above calculation to console
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compareSalary = salaryOne > salaryTwo; //uses boolean to compare the two salaries
            Console.WriteLine(compareSalary); //displays result to console as true or false value
        }
    }
}

using System;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); //user input string data type
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine(); //user input string data type
            Console.WriteLine("What page number?");
            int page = int.Parse(Console.ReadLine()); //user input integer data type
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string help = Console.ReadLine(); //user input string data type
            bool myBool = Convert.ToBoolean(help); //converts string to boolean data type
            Console.WriteLine("Were there any positive experiences you'd like to share?");
            string positive = Console.ReadLine(); //user input string data type
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine(); //user input string data type
            Console.WriteLine("How many hours did you study today?");
            int hours = int.Parse(Console.ReadLine()); //user input integer data type
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}

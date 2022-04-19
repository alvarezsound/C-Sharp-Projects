using System;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int page = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string help = Console.ReadLine();
            bool myBool = Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you'd like to share?");
            string positive = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}

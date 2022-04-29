using System;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week.");
                string userValue = Console.ReadLine();

                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userValue);

                if (day == DaysOfTheWeek.Friday)
                {
                    Console.WriteLine("Today is Friday.");
                }
                else
                {
                    Console.WriteLine("Today is not " + day);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.Read();
        }

        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}

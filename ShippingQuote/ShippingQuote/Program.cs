using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            string weightInput = Console.ReadLine(); //user inputs a number as a string
            int weight = Convert.ToInt32(weightInput); //converts the string to integer

            if (weight > 50) // if statement to check weight condition
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // if condition is true then thhe above message will display and program ends
            }

            Console.WriteLine("Please enter the package height:");
            string heightInput = Console.ReadLine(); //user inputs a number as a string
            int height = Convert.ToInt32(heightInput); //converts the string to integer 

            Console.WriteLine("Please enter the package width:");
            string widthInput = Console.ReadLine(); //user inputs a number as a string
            int width = Convert.ToInt32(widthInput); //converts the string to integer

            Console.WriteLine("Please enter the package length:");
            string lengthInput = Console.ReadLine(); //user inputs a number as a string
            int length = Convert.ToInt32(lengthInput); //converts the string to integer

            int dimensions = length + width + height; //add up all the dimensions
            if (dimensions > 50) // if statement to check dimension condition
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // if condition is true then the above message will display and program ends
            }
            int result = ((height * width * length) * weight) / 100; // math to find the cost of shipping
            Console.WriteLine("Your estimated total for shipping this package is: " + result.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"))); // displays result in dollar amount to console
            Console.WriteLine("Thank you!");
        }
    }
}

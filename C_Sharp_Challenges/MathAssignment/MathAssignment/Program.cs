using System;

namespace MathAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string numberOne = Console.ReadLine(); //user inputs a number as a string
            int numOne = Convert.ToInt32(numberOne); //converts the string to integer for math
            int totalOne = numOne * 50; //multiplies users input with 50
            Console.WriteLine("Your number times 50 is: " + totalOne); //displays string + result to console

            Console.WriteLine("Enter a number:");
            string numberTwo = Console.ReadLine(); //user inputs a number as a string
            int numTwo = Convert.ToInt32(numberTwo); //converts the string to integer for math
            int totalTwo = numTwo + 25; //adds users input with 25
            Console.WriteLine("Your number plus 25 is: " + totalTwo); //displays string + result to console

            Console.WriteLine("Enter a number:");
            string numberThree = Console.ReadLine(); //user inputs a number as a string
            double numThree = Convert.ToDouble(numberThree); //converts the string to double for division
            double totalThree = numThree / 12.5; //divides users input by 12.5
            Console.WriteLine("Your number divide by 12.5 is: " + totalThree); //displays string + result to console

            Console.WriteLine("Enter a number:");
            string numberFour = Console.ReadLine(); //user inputs a number as a string
            int numFour = Convert.ToInt32(numberFour); //converts the string to double for operation
            bool totalFour = numFour > 50; //compares users input to 50
            Console.WriteLine("Is your number greater than 50?: " + totalFour); //displays string + result to console

            Console.WriteLine("Enter a number:");
            string numberFive = Console.ReadLine(); //user inputs a number as a string
            int numFive = Convert.ToInt32(numberFive); //converts the string to integer for math
            int totalFive = numFive % 7; //divides users input by 7 and finds the remainder
            Console.WriteLine("The remainder of your number divided by 7 is: " + totalFive); //displays string + result to console
            Console.ReadLine();
        }
    }
}

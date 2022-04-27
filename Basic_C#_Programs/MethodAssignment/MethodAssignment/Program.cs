using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var operatorObject = new Operation(); // instantiate the Operation class

            Console.WriteLine("Pick a number:");
            int userValue1 = Convert.ToInt32(Console.ReadLine()); // conver users input as string to int
            Console.WriteLine("Pick another number (optional)");

            int userValue2;
            int result;
            if (int.TryParse(Console.ReadLine(), out userValue2)) // if user inputs a second number
            {
                result = operatorObject.Math(userValue1, userValue2); // call method for both inputs
            }
            else
            {
                result = operatorObject.Math(userValue1); // else call method for first input only
            }
            Console.WriteLine(userValue1 + " + " + userValue2 + " + 4 = ");
            Console.WriteLine(result); // displays result to console
            Console.ReadLine();

        }
    }
}

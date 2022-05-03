using System;

namespace MainMethodAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 80;
            var objectOne = new Operation(); // instantiate the Operation class
            var resultOne = objectOne.Math(myNumber); // Call the method from Operation.cs and pass in the integer
            Console.WriteLine(resultOne);

            double myDecimal = 20.5;
            var objectTwo = new Operation(); // instantiate the Operation class
            var resultTwo = objectTwo.Math(myDecimal); // Call the method from Operation.cs and pass in the double/decimal
            Console.WriteLine(resultTwo);

            string myString = "40";
            var objectThree = new Operation(); // instantiate the Operation class
            var resultThree = objectThree.Math(myString); // Call the method from Operation.cs and pass in the string
            Console.WriteLine(resultThree);

            Console.ReadLine();
        }
    }
}

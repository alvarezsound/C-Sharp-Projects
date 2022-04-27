using System;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var operatorObject = new Operation(); // instantiate the Operation class

            // void method exercise
            Console.WriteLine("Pick a number:");
            int userData = Convert.ToInt32(Console.ReadLine()); // convert users input as string to int
            Console.WriteLine("Half of " + userData + " is:");
            operatorObject.Math1(userData); // call method and pass in the users input

            // output parameters exercise
            Console.WriteLine("40 * 20 = ");
            operatorObject.Math2(a: 40, b: 20, out int c);
            Console.WriteLine(c);

            // method overload exercise
            Console.WriteLine("40 / 20 = ");
            int operation = operatorObject.Math2(a: 40, b: 20);
            Console.WriteLine(operation);

            // static class exercise
            Console.WriteLine(StaticClass.myMessage);

            Console.ReadLine();
        }
    }
}

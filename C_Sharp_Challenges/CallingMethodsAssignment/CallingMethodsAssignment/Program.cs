using System;


namespace CallingMethodsAssignment
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine(); // user inputs a number as string
            Data = Int32.Parse(input); // convert string to int for operations
            var operatorObject = new Operator(); // create a new object from the Operator class
            Console.WriteLine(Data + " + 4 =");
            var resultOne = operatorObject.Add(Data); // call the Add method from Operator.cs
            Console.WriteLine(resultOne); // display result to console
            Console.WriteLine(Data + " - 2 =");
            var resultTwo = operatorObject.Subtract(Data); // call the Subtract method from Operator.cs
            Console.WriteLine(resultTwo); // display result to console
            Console.WriteLine(Data + " / 2 =");
            var resultThree = operatorObject.Divide(Data); // call the Divide method from Operator.cs
            Console.WriteLine(resultThree); // display result to console
            Console.ReadLine();
        }
    }
}
using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var operatorObject = new Operation(); // instantiate the Operation class
            operatorObject.Math(4, 8); // call method and passing in two integers
            operatorObject.Math(a: 20, b: 40); // specifying paramters by name
            Console.ReadLine();
        }
    }
}

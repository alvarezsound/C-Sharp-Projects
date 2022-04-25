using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // initialize

            //while (true) // while statement
            //{
            //    Console.WriteLine("i = {0}", i); // display "i = "in the console
            //    i++; // increments i by one

            //    if (i > 20) // continutes the loop and increments until statement is true.
            //        break;
            //}

            do // do while statement
            {
                Console.WriteLine("i = {0}", i); // display "i = " in the console
                i++; // increments i by one


            } while (i < 20); // continutes the loop and increments until statement is false.
        }
    }
}

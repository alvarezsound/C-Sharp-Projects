using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> numList = new List<int>{ // add items to list
            24,
            58,
            26,
            34,
            42,
            20,
            8
            };

            Console.WriteLine("Please enter a number to divide by.");
            string numInput = Console.ReadLine(); // users input as a string
            int numDivide = Convert.ToInt32(numInput); // converts users input to a integer

            Console.WriteLine("The numbers in the list divided by your number:");
            foreach (var num in numList) // loop
            {
                var result = num / numDivide; // iterates through each number in list and divides by users number
                Console.WriteLine(result); // display each result
            }

        }
        catch (FormatException ex) // format exception for non-whole numbers and strings
        {
            Console.WriteLine("Please type a whole number.");
            //return;
        }
        catch (DivideByZeroException ex) // divide by 0 exception
        {
            Console.WriteLine("You cannot divide by zero.");
            //return;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        //finally
        //{
        //    Console.ReadLine();
        //}
        Console.WriteLine("The program has emerged from the try/catch block!");
        Console.ReadLine();
    }
}

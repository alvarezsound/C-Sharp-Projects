using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] stringArray = { "Dog", "Cat", "Bear", "Eagle", "Frog" }; // create string array

        Console.WriteLine("Please select an index of the array. Choose a number from 0-4.");
        string choiceOne = Console.ReadLine(); // users input as a string
        int indexOne = Convert.ToInt32(choiceOne); // converts users input to a integer

        if (indexOne > 4) 
        {
            Console.WriteLine("Invalid index!"); // error message displays if user input is > 4

        }
        else
        {
            Console.WriteLine(stringArray[indexOne]); // else the string is displayed at the selected index
        }

        int[] numArray = { 2, 4, 5, 8, 10, 12, 14 }; // create int array

        Console.WriteLine("Please select an index of the array. Choose a number from 0-6.");
        string choiceTwo = Console.ReadLine(); // users input as a string
        int indexTwo = Convert.ToInt32(choiceTwo); // converts users input to a integer

        if (indexTwo > 6) 
        {
            Console.WriteLine("Invalid index!"); // error message displays if user input is > 6

        }
        else
        {
            Console.WriteLine(numArray[indexTwo]); // else the int is displayed at the selected index
        }

        List<string> stringList = new List<string>(); // create string list
        stringList.Add("Dog"); // add items to list
        stringList.Add("Cat");
        stringList.Add("Bear");
        stringList.Add("Eagle");
        stringList.Add("Frog");

        Console.WriteLine("Please select an index of the list. Choose a number from 0-4.");
        string choiceThree = Console.ReadLine(); // users input as a string
        int indexThree = Convert.ToInt32(choiceThree); // converts users input to a integer

        if (indexThree > 4)
        {
            Console.WriteLine("Invalid index!"); // error message displays if user input is > 6

        }
        else
        {
            Console.WriteLine(stringList[indexThree]); // else the string is displayed at the selected index


            Console.ReadLine();



        }
    }
}


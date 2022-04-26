using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // PART 1
        //string[] fNames = { "Bobby ", "Jack ", "Erica ", "Betsy ", "Jenna " }; // create string array

        //Console.WriteLine("Insert a Last Name");
        //string lName = Console.ReadLine(); // user inputs a last name

        //for (int i = 0; i < fNames.Length; i++)
        //{
        //    fNames[i] = fNames[i] + lName; // iteratese through the array and adds the users input to each index
        //}

        //foreach (var names in fNames) // loops through each name in array with added last name
        //{
        //    Console.WriteLine(names); // prints names too console
        //}


        // PART 2
        //int count = 0;

        //while (true)
        //{
        //    Console.WriteLine("Count = {0}.", count);
        //    count++; // fixes infinite loop

        //    if (count > 10)
        //    {
        //        break; // fixes infinite loop
        //    }
        //}


        //PART 3
        //char[] arrayOne = { 'H', 'e', 'l', 'l', 'o' };

        //for (int i = 0; i < arrayOne.Length; i++) // < example
        //{
        //    Console.WriteLine(arrayOne[i]);
        //}

        //for (int x = 0; x <= 5; x++) // <= example
        //{
        //    Console.WriteLine(x);
        //}


        // PART 4
        //List<string> animals = new List<string>(); // create string list
        //animals.Add("Dog"); // add items to list
        //animals.Add("Cat");
        //animals.Add("Bear");
        //animals.Add("Eagle");
        //animals.Add("Frog");
        //animals.Add("Lizard");
        //animals.Add("Penguin");
        //animals.Add("Dog");

        //Console.WriteLine("Input text to search the animals index in the list!");
        //string searchWord = Console.ReadLine(); // users input as a string

        //int idx = animals.IndexOf(searchWord); // finds the index of item in list
        //if (idx > 0)
        //    Console.WriteLine($"The animals index in list is: {idx}"); // if input matches item in list
        //else
        //    Console.WriteLine("Animal is not in the list"); // else input does not match

        //Console.ReadLine();


        // PART 5
        //List<string> favSports = new List<string>(); // create string list
        //favSports.Add("Hockey"); // add items to list
        //favSports.Add("Lacrosse");
        //favSports.Add("Tennis");
        //favSports.Add("Football");
        //favSports.Add("Soccer");
        //favSports.Add("Baseball");
        //favSports.Add("Football");
        //favSports.Add("Football");

        //Console.WriteLine("Input text to search the sport's index in the favorite sports list!");
        //string searchSport = Console.ReadLine(); // users input as a string

        //if (favSports.Contains(searchSport)) // if users input matches an item in the list
        //{
        //    for (int index = 0; index < favSports.Count; index++) // iterates through the list and finds ALL indices of the searched sport
        //        if (favSports[index] == searchSport)
        //            Console.WriteLine(index);
        //}
        //else
        //    Console.WriteLine("Sport is not in the list"); // else input does not match // else display this error message

        //Console.ReadLine();


        //PART 6
        List<string> months = new List<string>{ // add items to list
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "Jan",
        "May",
        "Jun"
        };

        IEnumerable<string> duplicates = months.GroupBy(x => x)
                                            .SelectMany(g => g.Skip(1)); // define what a duplicate is

        foreach (string month in months) // foreach loop to iterate through all items in the list
        {
            if (duplicates.Contains(month)) // if month is a duplicate
            {
                Console.WriteLine("The month " + month + " is a duplicate."); // displays duplicate month
            }
            else
                Console.WriteLine("The month " + month + " is not a duplicate."); // displays non duplicate months

        }
        Console.ReadLine();
    }
}

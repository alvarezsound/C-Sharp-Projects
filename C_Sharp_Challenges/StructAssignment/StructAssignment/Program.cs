using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers amount = new Numbers(); // create object with data type Numbers from struct
            amount.Amount = 15.4368m; // assign amount
            Console.WriteLine(amount.Amount);
            Console.ReadLine();
        }
    }
}
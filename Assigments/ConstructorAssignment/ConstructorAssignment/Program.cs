using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // const variable
            const string name = "Jeff";

            // var variable
            var id = 27;

            // Chain 2 constructors together
            Construct con1 = new Construct(), con2 = new Construct("Jenna", 21);

            Console.WriteLine(con1.name + " " + con1.id);
            Console.WriteLine(con2.name + " " + con2.id);

            Console.Read();
        }
    }
}
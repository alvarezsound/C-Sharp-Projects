using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jeff";
            //string quote = "\"The man said, \"Hello\", Jeff. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Jeff";

            //bool trueOrFalse = name.Contains("f");
            //trueOrFalse = name.EndsWith("e");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(quote);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jeff");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

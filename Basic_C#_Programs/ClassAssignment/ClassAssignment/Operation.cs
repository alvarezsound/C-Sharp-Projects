using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    class Operation
    {
        public void Math1(int data)
        {
            int half = data / 2; // divide data by 2
            Console.WriteLine(half);
        }

        public int Math2(int a, int b, out int c) // method with output parameters
        {
            c = a * b;
            return c;
        }

        public int Math2(int a, int b) // method overload
        {
            return a / b;
        }
    }
}

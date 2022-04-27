using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssignment
{
    public class Operation
    {
        public int Math(int data) // method that takes in integer
        {
            return data + 4;
        }

        public double Math(double data) // method that takes in double/decimals
        {
            return data * 2.5;
        }

        public string Math(string data) // method that takes in strings
        {
            int myData = Convert.ToInt32(data); // converts string to int
            int result = myData / 4;
            return result.ToString(); // converts result back to string
        }

    }
}

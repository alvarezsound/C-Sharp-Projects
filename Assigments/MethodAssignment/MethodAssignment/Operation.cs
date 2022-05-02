using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAssignment
{
    class Operation
    {
        public int Math(int dataOne, int dataTwo = 0) 
            // Method that takes in two integers. The second integer has a default value of 0 in case user does not input a number.
        {
            return dataOne + dataTwo + 4;
        }
    }
}

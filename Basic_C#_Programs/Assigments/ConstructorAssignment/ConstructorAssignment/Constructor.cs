using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.cs
{
    public class Construct
    {
        public string name;
        public int id;

        public Construct() : this("Jeff", 27)
        {

        }
        public Construct(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
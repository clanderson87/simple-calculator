using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Stack
    {
        public string lastQ { get; set; }
        public int last { get; set; }

        public static Dictionary<char, int> constant = new Dictionary<char, int>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Expression
    {
        //setting things up, making operands available to eerething.
        private static readonly char[] operands = "+-*/%".ToCharArray();

        public string[] GetExpressionTerms(string input)
        { 
            int splitHere = input.IndexOfAny(operands);
            char Op = input[splitHere];
            string[] result = input.Split(Op);
            return result;
        }

        public char GetTheOp(string input)
        {
            int splitHere = input.IndexOfAny(operands);
            char Op = input[splitHere];
            return Op;
        }
    }
}

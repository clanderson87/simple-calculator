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
        public static readonly char[] operands = "+-*/%=".ToCharArray();

        public int GetConstant(char input)
        {
            try
            {
                return Stack.constant[input];
            }
            catch (Exception)
            {
                return 0;
            }
        }

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

            if (splitHere == -1 && input.Length < 1)
            {
                char inputChar = Convert.ToChar(input);
                return Convert.ToChar(Stack.constant[inputChar]);
            }
            else
            {
                char Op = input[splitHere];
                return Op;
            }
        }
    }
}

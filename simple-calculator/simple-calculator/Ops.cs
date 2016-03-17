using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Ops
    {
        public static int Answer = 0;

        public static int Add(int num1, int num2)
        {
            Answer = num1 + num2;
            return Answer;
        }
        public static int Minus(int num1, int num2)
        {
            Answer = num1 - num2;
            return Answer;
        }
        public static int Times(int num1, int num2)
        {
            Answer = num1 * num2;
            return Answer;
        }
        public static int Divide(int num1, int num2)
        {
            Answer = num1 / num2;
            return Answer;
        }
        public static int Remainder(int num1, int num2)
        {
            Answer = num1 % num2;
            return Answer;
        }
    }
}
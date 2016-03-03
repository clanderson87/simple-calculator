using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator.Tests
{
    public class Ops
    {
        public static int Answer = 0;

        public static void Add(int num1, int num2)
        {
            Answer = num1 + num2;
            Console.WriteLine(Answer);
        }
        public static void Minus(int num1, int num2)
        {
            Answer = num1 - num2;
            Console.WriteLine(Answer);
        }
        public static void Times(int num1, int num2)
        {
            Answer = num1 * num2;
            Console.WriteLine(Answer);
        }
        public static void Divide(int num1, int num2)
        {
            Answer = num1 / num2;
            Console.WriteLine(Answer);
        }
        public static void Remainder(int num1, int num2)
        {
            Answer = num1 % num2;
            Console.WriteLine("You got " + Answer + " left over.");
        }
    }
}
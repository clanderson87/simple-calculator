using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Terminal : Expression
    {
        public int count { get; set; }

        public Terminal()
        {
            count = 0;
        }

        MathOps main_calc = new MathOps();

        public void GetFirstInput()
        {
            Console.WriteLine("["+count+"]");
            string input = Console.ReadLine();
            main_calc.my_stack = main_calc.DoTheThing(input);
            if (input.IndexOfAny(Expression.operands) != -1)
            {
                count++;
                GetFirstInput();
            }
            else if (input.Length > 2)
            {
                DealingWithWords(input);
                count++;
                GetFirstInput();
            }
            else
            {
                char constantChar = Convert.ToChar(input);
                char result = Convert.ToChar(GetConstant(constantChar));
                Console.WriteLine(result);
                count++;
                GetFirstInput();
            }
            
        }

        public void DealingWithWords(string input)
        {
            if(input == "quit" || input == "exit")
            {
                Console.WriteLine("Bye, Felicia");
                Environment.Exit(1);
            } else if (input == "last")
            {
                Console.WriteLine(main_calc.my_stack.last);
            } else if (input == "lastq")
            {
                Console.WriteLine(main_calc.my_stack.lastQ);
            }
        }

        public void GetNextInput()
        {
            string input = Console.ReadLine();
        }
    }
}

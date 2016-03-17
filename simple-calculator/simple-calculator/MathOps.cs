using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class MathOps : Expression
    {
        public Stack my_stack = new Stack();

        public Stack DoTheThing(string mainExp)
        { 
            Terminal term = new Terminal();
            //making usable things to pass to Expression
            string input = mainExp;
            if (input == "last" || input == "lastq" || input == "exit")
            {
                term.DealingWithWords(input);
                return my_stack;
            }
            string[] TermsArray  = GetExpressionTerms(input);
            //getting the Op
            char opToDo = GetTheOp(input);

            char TermA = Convert.ToChar(TermsArray[0].Replace(" ", ""));
            char TermB = Convert.ToChar(TermsArray[1].Replace(" ", ""));


            if ((Char.IsLetter(TermA) == true) && (Char.IsNumber(TermB) == true) && (opToDo == '='))
            {
                int Term2 = Convert.ToInt32(TermsArray[1]);

                Stack.constant.Add(TermA, Term2);
                my_stack.lastQ = Term2 + " saved as " + TermA;
                my_stack.last = Term2;
                Console.WriteLine(my_stack.lastQ);
                return my_stack;
            }
            else if ((Char.IsLetter(TermB) == true) && (Char.IsNumber(TermA) == true) && (opToDo == '='))
            {
                int Term1 = Convert.ToInt32(TermsArray[0]);

                Stack.constant.Add(TermB, Term1);
                my_stack.lastQ = (Term1 + " saved as " + TermB);
                my_stack.last = Term1;
                Console.WriteLine(my_stack.lastQ);
                return my_stack;
            }
            else
            {
                if ((Char.IsLetter(TermA) == true) && (Char.IsLetter(TermB) == true) && opToDo != '=')
                {
                    TermsArray[0] = Stack.constant[TermA].ToString();
                    TermsArray[1] = Stack.constant[TermB].ToString();
                }
                else if((Char.IsLetter(TermA) == true) && opToDo != '=')
                {
                    TermsArray[0] = Stack.constant[TermA].ToString();
                }
                else if((Char.IsLetter(TermB) == true) && opToDo != '=')
                {
                    TermsArray[1] = Stack.constant[TermB].ToString();
                }

                int Term1 = Convert.ToInt32(TermsArray[0]);
                int Term2 = Convert.ToInt32(TermsArray[1]);

                //Doing the math, returning the stack
                if (opToDo == '+')
                {
                    my_stack.last = Ops.Add(Term1, Term2);
                    my_stack.lastQ = mainExp;
                    Console.WriteLine(my_stack.last);
                    return my_stack;
                }
                else if (opToDo == '-')
                {
                    my_stack.last = Ops.Minus(Term1, Term2);
                    my_stack.lastQ = mainExp;
                    Console.WriteLine(my_stack.last);
                    return my_stack;
                }
                else if (opToDo == '*')
                {
                    my_stack.last = Ops.Times(Term1, Term2);
                    my_stack.lastQ = mainExp;
                    Console.WriteLine(my_stack.last);
                    return my_stack;
                }
                else if (opToDo == '/')
                {
                    my_stack.last = Ops.Divide(Term1, Term2);
                    my_stack.lastQ = mainExp;
                    Console.WriteLine(my_stack.last);
                    return my_stack;
                }
                else if (opToDo == '%')
                {
                    my_stack.last = Ops.Remainder(Term1, Term2);
                    my_stack.lastQ = mainExp;
                    Console.WriteLine(my_stack.last);
                    return my_stack;
                }
                else
                {
                    my_stack.last = 0;
                    my_stack.lastQ = "Wtf, brah?";
                    Console.WriteLine(my_stack.lastQ);
                    return my_stack;
                }
            }
        }   
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator.Tests
{
    public  class MathOps : Expression
    {
        
        public int DoTheThing(string mainExp)
        {
            Expression my_exp = new Expression();
            string input = mainExp;
            string[] TermsArray  = my_exp.GetExpressionTerms(input);
            int Term1 = Convert.ToInt32(TermsArray[0]);
            int Term2 = Convert.ToInt32(TermsArray[1]);
            char opToDo = my_exp.GetTheOp(input);
            if (opToDo == '+')
            {
                return Ops.Add(Term1, Term2);
            }
            else if(opToDo == '-')
            {
                return Ops.Minus(Term1, Term2);
            }
            else if(opToDo == '*')
            {
                return Ops.Times(Term1, Term2);
            }
            else if(opToDo == '/')
            {
                return Ops.Divide(Term1, Term2);
            }
            else if(opToDo== '%')
            {
                return Ops.Remainder(Term1, Term2);
            }
            else
            {
                return 0;
            }
            
        }   
    }
}
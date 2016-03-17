using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_calculator.Tests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void StackEnsureICanInstantiateStack()
        {
            Stack my_stack = new Stack();
            Assert.IsNotNull(my_stack);
        }

        [TestMethod]
        public void StackEnsureICanGetLastQ()
        {
            MathOps my_mathOps = new MathOps();

            Stack my_stack = my_mathOps.DoTheThing("3 + 8");

            string actual = my_stack.lastQ;
            string expected = "3 + 8";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void StackEnsureICanGetLast()
        {
            MathOps my_mathOps = new MathOps();

            Stack my_stack = my_mathOps.DoTheThing("5 + 9");

            int actual = my_stack.last;
            //int expected = 14;

            Assert.AreEqual(14, actual);
        }

        [TestMethod]
        public void StackEnsureICanConstant()
        {
            Stack my_stack = new Stack();
            Assert.IsNotNull(Stack.constant);
        }

        [TestMethod]
        public void StackEnsureAConstantDoesntFuckupLastQString()
        {
            MathOps my_MathOps = new MathOps();

            Stack myStack = my_MathOps.DoTheThing("a = 7");
            //string expected = "7 saved as a";
            string actual = myStack.lastQ;

            Assert.AreEqual("7 saved as a", actual);
        }

        [TestMethod]
        public void StackEnsureAConstantDoesntFuckupLastQStringBackwards()
        {
            MathOps my_MathOps = new MathOps();

            Stack myStack = my_MathOps.DoTheThing("9 = x");
            //string expected = "7 saved as a";
            string actual = myStack.lastQ;

            Assert.AreEqual("9 saved as x", actual);
        }


        [TestMethod]
        public void StackEnsureAConstantDoesntFuckupLast()
        {
            MathOps my_MathOps = new MathOps();

            Stack myStack = my_MathOps.DoTheThing("b = 6");
            //int expected = 6;

            Assert.AreEqual(6, Stack.constant['b']);
        }

        [TestMethod]
        public void StackEnsureICanCallAConstant()
        {
            MathOps my_MathOps = new MathOps();

            Stack myStack = my_MathOps.DoTheThing("b = 6");
            //int expected = 6;
            Stack newStack = my_MathOps.DoTheThing("b + 6");

            Assert.AreEqual(newStack.last, 12);
        }
    }
}

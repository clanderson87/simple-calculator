using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_calculator.Tests
{
    [TestClass]
    public class MathOpsTests
    {
        [TestMethod]
        public void MathOpsProveThatThisShitWorks()
        {
            MathOps my_mathOps = new MathOps();
            Assert.IsNotNull(my_mathOps);
        }

        //[TestMethod]
        //public void MathOpsProveThatICanParseAndPerformAnOp()
        //{
        //    MathOps my_mathOps = new MathOps();

        //    int actual = my_mathOps.DoTheThing("4*5");
        //    int expected = 20;

        //    Assert.AreEqual(actual, expected);

        //}

        //[TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        //public void MathOpsBadInputException()
        //{
        //    MathOps my_mathOps = new MathOps();

        //    int actual = my_mathOps.DoTheThing("3?2");
            
        //}
    }
}

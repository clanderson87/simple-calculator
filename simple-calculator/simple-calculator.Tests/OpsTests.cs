using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_calculator.Tests
{
    [TestClass]
    public class OpsTests
    {
        [TestMethod]
        public void OpsAddTheseThings()
        {
            //Arrange and Act
            Ops.Add(4, 3);
            //Assert
            Assert.AreEqual(Ops.Answer, 7);
        }
        [TestMethod]
        public void OpsSubtractThisStuff()
        {
            Ops.Minus(6, 2);
            Assert.AreEqual(Ops.Answer, 4);
        }
        [TestMethod]
        public void OpsMultiplyThisCrap()
        {
            Ops.Times(4, 5);
            Assert.AreEqual(Ops.Answer, 20);
        }
        [TestMethod]
        public void OpsDivideAndConquer()
        {
            Ops.Divide(10, 5);
            Assert.AreEqual(Ops.Answer, 2);
        }
        [TestMethod]
        public void AllThatRemainsIsTheRemainder()
        {
            Ops.Remainder(50, 8);
            Assert.AreEqual(Ops.Answer, 2);
        }
    }
}

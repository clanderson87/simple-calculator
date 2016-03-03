using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace simple_calculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void ExpEnsureICanInstantiateAnExpression()
        {
            //Arrange
            Expression my_Exp = new Expression();
            //Act: no action, we're just seeing if were here
            //Assert
            Assert.IsNotNull(my_Exp);
        }

        [TestMethod]
        public void ExpEnsureICanGetTwoTermsFromAString()
        {
            //Arrange
            Expression my_Exp = new Expression();

            //Act
            string input = "2 + 5";
            string[] actual = my_Exp.GetExpressionTerms(input);
            string[] expected = { "2 ", " 5" };
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ExpEnsureICanGetTheOp()
        {
            //Arrange
            Expression my_Exp = new Expression();

            //Act
            string input = "2 + 5";
            char actual = my_Exp.GetTheOp(input);
            char expected = '+';

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException]
        public void ExpEnsureExpressionHasValidTerms()
        {
            //Arrange
            Expression my_Exp = new Expression();

            //Act
            string input = "2 # 5";
            string[] actual = my_Exp.GetExpressionTerms(input);
        }
    }
}

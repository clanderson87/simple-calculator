using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_calculator.Tests
{
    [TestClass]
    public class TerminalTests
    {
        [TestMethod]
        public void TerminalEnsureTerminal()
        {
            Terminal term = new Terminal();
            Assert.IsNotNull(term);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderTests;

namespace TDD_CSharp.Factorial
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void FactorialCalculations()
        {
            Assert.AreEqual(1, Factorials.Calculate(0));
            Assert.AreEqual(1, Factorials.Calculate(1));
            Assert.AreEqual(2, Factorials.Calculate(2));

        }
    }
}

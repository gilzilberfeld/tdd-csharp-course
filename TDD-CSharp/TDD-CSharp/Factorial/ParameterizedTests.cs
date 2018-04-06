using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderTests;

namespace TDD_CSharp.Factorial
{
    [TestClass]
    public class ParameterizedFactorialTests
    {
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(2, 2)]
        [DataTestMethod]
        public void FactorialCalculations(int input, int expected)
        {
            Assert.AreEqual(expected, Factorials.Calculate(input));
        }
    }
}

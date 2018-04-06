using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

        public TestContext TestContext { get; set; }

        [DataTestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            @"Factorial\FactorialData.csv",
            "FactorialData#csv", 
            DataAccessMethod.Sequential)]
        public void FactorialCalculationsFromFile()
        {
            int input = Convert.ToInt32(TestContext.DataRow[0]);
            int result = Convert.ToInt32(TestContext.DataRow[1]);
            Assert.AreEqual(result, Factorials.Calculate(input));
        }
    }
}

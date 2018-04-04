using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderTests;

namespace TDD_CSharp
{
    [TestClass]
    public class CalculatorDisplaysTests
    {
        [TestMethod]
        public void displayShowsZeroAtStart()
        {
            CalculatorDisplay calc = new CalculatorDisplay();
            string result = calc.GetDisplay();
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void OnPress1_Display_1()
        {
            CalculatorDisplay calc = new CalculatorDisplay();
            calc.PressKey('1');
            string result = calc.GetDisplay();
            Assert.AreEqual("1", result);
        }
        
    }
}

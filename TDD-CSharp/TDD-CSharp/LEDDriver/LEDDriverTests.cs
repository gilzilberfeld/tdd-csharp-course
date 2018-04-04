using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderTests;

namespace TDD_CSharp
{
    [TestClass]
    public class LEDDriverTests
    {
        [TestMethod]
        public void All_LEDs_Are_Off_After_Initialization()
        {
            LEDDriver driver = new LEDDriver();
            driver.InitializeLEDs();
            Assert.IsFalse(driver.AreAllLEDsOn());
        }

        [TestMethod]
        public void All_LEDs_Are_On_After_Turning_All_On()
        {

        }
    }
}

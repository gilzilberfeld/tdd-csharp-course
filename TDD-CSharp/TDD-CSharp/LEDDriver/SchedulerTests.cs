using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderTests;
using Moq;

namespace TDD_CSharp
{
    [TestClass]
    public class SchedulerTests
    {
        Mock<ITimeService> mockTimeService;
        LEDDriver driver;
        Scheduler scheduler;

        [TestInitialize]
        public void Setup()
        {
            mockTimeService = new Mock<ITimeService>();
            driver = new LEDDriver();
            scheduler = new Scheduler(mockTimeService.Object, driver);
        }

        [TestMethod]
        public void WhenYearIs2018_LightsAreOff()
        {
            mockTimeService
                .Setup(service => service.GetCurrentYear())
                .Returns(2018);

            scheduler.TurnLEDSonOnTime();
            Assert.IsFalse(driver.AreAllLEDsOn());
        }

        [TestMethod]
        public void WhenYearIs2000_LightsAreOn()
        {
            mockTimeService
                .Setup(service => service.GetCurrentYear())
                .Returns(2000);

            scheduler.TurnLEDSonOnTime();
            Assert.IsTrue(driver.AreAllLEDsOn());
        }

 
    }
}

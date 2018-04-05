using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderTests;

namespace TDD_CSharp
{
    [TestClass]
    public class SchedulerTests_Manual
    {
        TimeServiceMock mockTimeService;
        LEDDriver driver;
        Scheduler scheduler;

        [TestInitialize]
        public void Setup()
        {
            mockTimeService = new TimeServiceMock();
            driver = new LEDDriver();
            scheduler = new Scheduler(mockTimeService, driver);
        }

        [TestMethod]
        public void WhenYearIs2018_LightsAreOff()
        {
            mockTimeService.returnedYear = 2018;

            scheduler.TurnLEDSonOnTime();
            Assert.IsFalse(driver.AreAllLEDsOn());
        }

        [TestMethod]
        public void WhenYearIs2000_LightsAreOn()
        {
            mockTimeService.returnedYear = 2000;

            scheduler.TurnLEDSonOnTime();
            Assert.IsTrue(driver.AreAllLEDsOn());
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests;
using UnderTests;

namespace TDD_CSharp
{
    [TestClass]
    public class SchedulerTests_Manual
    {
        TimeServiceMock mockTimeService;
        ILEDDriver driver;
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

        [TestMethod]
        public async void WhenSchedulerInitializeLEDs_StateIsReady()
        {
            LEDDriverMock driver = new LEDDriverMock(true);
            State result = await scheduler.InitializeNewLEDDriverAsync(driver);
            Assert.AreEqual(State.Ready, result);
        }

        [TestMethod]
        public async void WhenLEDDriverTimesOut_StateIsTimeOut()
        {
            LEDDriverMock driver = new LEDDriverMock(false);
            State result = await scheduler.InitializeNewLEDDriverAsync(driver);
            Assert.AreEqual(State.TimeOut, result);
        }
    }
}

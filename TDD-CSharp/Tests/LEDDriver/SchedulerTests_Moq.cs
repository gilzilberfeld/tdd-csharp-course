using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderTests;
using Moq;
using System.Threading.Tasks;

namespace TDD_CSharp
{
    [TestClass]
    public class SchedulerTests_Moq
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

        [TestMethod]
        public void TimeServiceWasCalled()
        {
            mockTimeService
                .Setup(service => service.GetCurrentYear())
                .Returns(2000);

            scheduler.TurnLEDSonOnTime();
            
            // method was called
            mockTimeService.Verify(d => d.GetCurrentYear());

            // method was called once
            mockTimeService.Verify(d => d.GetCurrentYear(), Times.Once);

        }

        [TestMethod]
        public async void WhenSchedulerInitializeLEDs_StateIsReady()
        {
            Mock<ILEDDriver> mockDriver = new Mock<ILEDDriver>();
            mockDriver.Setup(driver =>
                driver.InitializeAsync())
                .ReturnsAsync(State.Ready);
                
            State result = await scheduler.InitializeNewLEDDriverAsync(driver);
            Assert.AreEqual(State.Ready, result);

        }

        [TestMethod]
        public async void WhenLEDDriverTimesOut_StateIsTimeOut()
        {
            Mock<ILEDDriver> mockDriver = new Mock<ILEDDriver>();
            mockDriver.Setup(driver =>
                driver.InitializeAsync())
                .ThrowsAsync(new TimeOutException());
            
            
            State result = await scheduler.InitializeNewLEDDriverAsync(driver);
            Assert.AreEqual(State.TimeOut, result);
        }



    }
}

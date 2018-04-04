using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_CSharp
{
    [TestClass]
    public class SchedulerTests
    {
        [TestInitialize]
        public void Setup()
        {
            //RESET_FAKE(getCurrentYearFromService);
        }

        [TestMethod]
        public void WhenYearIs2000_LightsAreOn()
        {
            /*            getCurrentYearFromService_fake.return_val = 2000;

                        schedulerInit();
                        schedulerTurnLEDSonOnTime();
                        Assert.AreEqual(driverAreAllLEDsOn());
             */
        }

        [TestMethod]
        public void WhenYearIs2018_LightsAreOff()
        {
            /*
            getCurrentYearFromService_fake.return_val = 2018;

            schedulerInit();
            schedulerTurnLEDSonOnTime();
            CHECK(!driverAreAllLEDsOn());
            */
        }

    }
}

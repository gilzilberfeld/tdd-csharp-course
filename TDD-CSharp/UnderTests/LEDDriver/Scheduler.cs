﻿namespace UnderTests
{
    public class Scheduler
    {
        LEDDriver driver;
        TimeService timeService;

        public Scheduler(TimeService timeService, LEDDriver driver )
        {
            this.timeService = timeService;
            timeService.Init();
            this.driver = driver;
            driver.InitializeLEDs();
        }

        void TurnLEDSonOnTime()
        {
            if (ItsTime())
            {
                driver.TurnAllOn();
            }
        }

        bool ItsTime()
        {
            // the function is defined elsewhere and
            // needs to be faked to be tested
            if (timeService.GetCurrentYear() == 2000)
                return true;
            else
                return false;
        }

    }
}
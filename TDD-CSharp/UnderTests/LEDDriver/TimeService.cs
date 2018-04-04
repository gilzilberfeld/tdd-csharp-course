using System;

namespace UnderTests
{
    public class TimeService: ITimeService
    {
        bool isInitialized = false;

        public void Init()
        {
            isInitialized = true;
        }

        public int GetCurrentYear()
        {
            return DateTime.Now.Year;
        }
    }
}

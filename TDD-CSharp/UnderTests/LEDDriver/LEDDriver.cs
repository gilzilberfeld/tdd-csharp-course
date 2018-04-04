using System;

namespace UnderTests
{
    public class LEDDriver
    {
        bool ledsAreOn = false;
        UInt16 address = 0;

        public void InitializeLEDs()
        {
            ledsAreOn = false;
        }

        public void TurnAllOn()
        {
            ledsAreOn = true;
        }


        public bool AreAllLEDsOn()
        {
            return ledsAreOn;
        }

    }
}

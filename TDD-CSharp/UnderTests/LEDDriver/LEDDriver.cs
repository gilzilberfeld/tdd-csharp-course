using System;
using System.Threading.Tasks;

namespace UnderTests
{
    public class LEDDriver : ILEDDriver
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

        public async Task<State> InitializeAsync()
        {
            throw new NotImplementedException();
        }
    }
}

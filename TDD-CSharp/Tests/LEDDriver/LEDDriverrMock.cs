using System.Threading.Tasks;
using UnderTests;

namespace Tests
{
    public class LEDDriverMock : ILEDDriver
    {
        bool isReady;

        public LEDDriverMock(bool state)
        {
            this.isReady = state;
        }

        public async Task<State> InitializeAsync()
        {
            if (isReady)
                return State.Ready;
            else
                throw new TimeOutException();
        }

        public bool AreAllLEDsOn()
        {
            throw new System.NotImplementedException();
        }

        public void InitializeLEDs()
        {
            throw new System.NotImplementedException();
        }

        public void TurnAllOn()
        {
            throw new System.NotImplementedException();
        }
    }
}

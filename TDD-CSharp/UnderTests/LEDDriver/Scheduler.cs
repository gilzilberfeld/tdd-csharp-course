using System.Threading.Tasks;

namespace UnderTests
{
    public class Scheduler
    {
        ILEDDriver driver;
        ITimeService timeService;

        public Scheduler(ITimeService timeService, ILEDDriver driver )
        {
            this.timeService = timeService;
            timeService.Init();
            this.driver = driver;
            driver.InitializeLEDs();
        }

        public void TurnLEDSonOnTime()
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

        public async Task<State> InitializeNewLEDDriverAsync(ILEDDriver driver)
        {
            try
            {
                State result = await driver.InitializeAsync();
                this.driver = driver;
                return result;
            }
            catch (TimeOutException)
            {
                return State.TimeOut;
            }
        }
    }
}

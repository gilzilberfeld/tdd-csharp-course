using System.Threading.Tasks;

namespace UnderTests
{
    public interface ILEDDriver
    {
        bool AreAllLEDsOn();
        Task<State> InitializeAsync();
        void InitializeLEDs();
        void TurnAllOn();
    }
}
using UnderTests;

namespace TDD_CSharp
{
    class TimeServiceMock : ITimeService
    {
        public int returnedYear;
        public int GetCurrentYear()
        {
            return returnedYear;
        }

        public void Init()
        {
            
        }
    }
}

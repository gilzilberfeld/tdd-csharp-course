namespace UnderTests
{
    public class CalculatorDisplay
    {
        private string display = "0";

        public void PressKey (char key)
        {
            if (key != '+')
            {
                if (display != "0")
                {
                    display += key;
                }
                else
                    display = key.ToString();
            }
        }

        public string GetDisplay()
        {
            return display;
        }
    }
}

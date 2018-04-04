namespace UnderTests
{
    public class Factorials
    {
        public static int Calculate(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Calculate(n - 1);
        }

    }
}

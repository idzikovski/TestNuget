using System;
namespace TestNuget
{
    public class TestClass
    {
        public TestClass()
        {
        }

        public static int CalculateDifference(int a, int b)
        {
            int result = 0;

            if (a > b)
            {
                result = a - b;
            }

            if (b >= a)
            {
                result = b - a;
            }

            return result;
        }
    }
}

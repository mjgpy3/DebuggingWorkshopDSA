using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebuggingWorkshop_DSA
{
    static class DebugMeMathTest
    {
        public static void DividingZeroByFiftyShouldBeZero()
        {
            double actual = DebugMeMath.Divide(0, 50);
            double expected = 0;

            TellUsResult(expected, actual, "We should get 0 when we divide 0 by something else");
        }

        public static void TheSumOfNumbersOneThroughNineShouldBeFortyFive()
        {
            int[] oneThroughNine = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int actual = DebugMeMath.Sum(oneThroughNine);
            int expected = 45;

            TellUsResult(expected, actual, "The sum of the number 1-9 should be 45");
        }

        public static void TellUsResult(Object expected, Object actual, string desc)
        {
            Console.WriteLine("Test: " + desc);
            Console.WriteLine("Expected: " + expected.ToString());
            Console.WriteLine("Actual: " + actual.ToString() + "\n");
        }

        public static void RunAllTests()
        {
            DividingZeroByFiftyShouldBeZero();
            TheSumOfNumbersOneThroughNineShouldBeFortyFive();

            Console.ReadLine(); // Make it pause so user can read output
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebuggingWorkshop_DSA
{
    /// <summary>
    /// A very broken math class used to illustrate using the VS debugger
    /// </summary>
    static class DebugMeMath
    {
        /// <summary>
        /// Divides `num` by `den` and returns the result
        /// </summary>
        public static double Divide(double den, double num)
        {
            return num / den;
        }

        /// <summary>
        /// Returns the sum of the integers in the passed array
        /// </summary>
        public static int Sum(int[] numbers)
        {
            int sum = 0;

            for (int i = numbers.Length; i > 0; i--)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}

using System;

namespace ValidationLibrary
{
    public class ValidationHelper
    {
        public static void CheckRangeValue(double value, double minValue, double maxValue, string errorMessage)
        {
            if (value < minValue ||  value > maxValue)
                throw new ArgumentException(nameof(value), errorMessage);
        }
    }
}
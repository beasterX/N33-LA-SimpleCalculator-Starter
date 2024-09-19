using System;

namespace SimpleCalculator
{
    public static class InputConverter
    {
        public static double ConvertInputToNumeric(string textInput)
        {
            if (double.TryParse(textInput, out double convertedNumber))
            {
                return convertedNumber;
            }
            else
            {
                throw new ArgumentException("Not a numeric value.");
            }
        }
    }
}

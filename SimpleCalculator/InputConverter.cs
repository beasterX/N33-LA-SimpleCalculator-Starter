using System;

namespace SimpleCalculator
{
    public static class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
           try
            {
                return Convert.ToDouble(argTextInput);
            }
            catch (FormatException)
            {
                throw new ArgumentException("Must be a numeric value.");
            }
          
        }
    }
}

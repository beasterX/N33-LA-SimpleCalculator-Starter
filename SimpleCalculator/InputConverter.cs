    using System;

    namespace SimpleCalculator
    {
        public static class InputConverter
        {
            public static double ConvertInputToNumeric(string argTextInput)
            {
                if (double.TryParse(argTextInput, out double convertedNumber))
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

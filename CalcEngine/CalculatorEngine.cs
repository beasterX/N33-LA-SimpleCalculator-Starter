using System;

namespace SimpleCalculator

{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            if (argOperation == "+" || argOperation.ToLower() == "add")
            {
                result = argFirstNumber + argSecondNumber;
            }
            else if (argOperation == "-" || argOperation.ToLower() == "subtract")
            {
                result = argFirstNumber - argSecondNumber;
            }
            else if (argOperation == "*" || argOperation.ToLower() == "multiply")
            {
                result = argFirstNumber * argSecondNumber;
            }
            else if (argOperation == "/" || argOperation.ToLower() == "divide")
            {
                if (argSecondNumber == 0)
                {
                    Console.WriteLine("cannot divide by zero. Try again please.");
                }
                else
                {
                    result = argFirstNumber / argSecondNumber;
                   
                }
            }

            return result;
        }
    }
}

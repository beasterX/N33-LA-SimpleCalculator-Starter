using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;
            switch (argOperation) {

                case "add":
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "subtract":
                    result = argFirstNumber - argSecondNumber;
                    break;

                case "divided":
                    result = argFirstNumber / argSecondNumber;
                    break;

                case "multiply":
                    result = argFirstNumber * argSecondNumber;
                    break;

                default:
                    result = 0;
                    break;
                }

                return result;
            }
        }
    }

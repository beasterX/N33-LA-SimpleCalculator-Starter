using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                string operation = GetValidOperation("Enter an operation: ");
                double firstNumber = GetValidNumber("Enter the first number: ");
                double secondNumber = GetValidNumber("Enter the second number: ");

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine($"{firstNumber} {GetOperationSymbol(operation)} {secondNumber} is equal to {result:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static double GetValidNumber(string n)
        {
            double number;
            Console.WriteLine(n);
            string input = Console.ReadLine();

            while (true)
            {
                try
                {
                    number = InputConverter.ConvertInputToNumeric(input);
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    input = Console.ReadLine();
                }
            }

            return number;
        }

        static string GetOperationSymbol(string operation)
        {
            switch (operation.ToLower())
            {
                case "add":
                    return "+";
                case "subtract":
                    return "-";
                case "multiply":
                    return "*";
                case "divide":
                    return "/";
                default:
                    return operation;
            }
        }
            static string GetValidOperation(string o)
        {
            Console.WriteLine(o);
            string operation = Console.ReadLine();

            while (!(operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "add" || operation == "subtract" || operation == "multiply" || operation == "divide"))
            {
                Console.WriteLine("Invalid operation!  Enter +, -, *, or /.");
                operation = Console.ReadLine();
            }

            return operation;
        }

        
    }
}

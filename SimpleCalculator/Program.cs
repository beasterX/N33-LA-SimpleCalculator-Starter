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

                double firstNumber = GetValidNumber("Enter the first number: ");
                double secondNumber = GetValidNumber("Enter the second number: ");
                string operation = GetValidOperation();
                if (operation == "divide")
                {
                    while (secondNumber == 0)
                    {
                        Console.WriteLine("Change numerical value to something other than 0");
                        secondNumber = GetValidNumber("Enter the second number: ");
                    }
                }

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                string formattedString= string.Format("{0} {1} {2} is equal to {3:F2}", firstNumber, operation ,secondNumber, result);
                Console.WriteLine(formattedString);
                Console.ReadKey();
            } catch (Exception ex)
            {
       
                Console.WriteLine(ex.Message);
            }
        }

        public static double GetValidNumber(string numberMessage)
        {
            double number;
            while (true)
            {
                Console.Write(numberMessage);
                string input = Console.ReadLine();
                try
                {
                    number = InputConverter.ConvertInputToNumeric(input);
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("enter a valid numeric value.");
                    
                }
            }
            return number;
        }
        public static string GetValidOperation()
        {
            while (true)
            {
                Console.Write("Enter the operation (+, -, *, /, add, subtract, multiply, divide): ");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                    case "add":
                        return "add";
                        break;
                    case "-":
                    case "subtract":
                        return "subtract";
                        break;
                    case "*":
                    case "multiply":
                        return "multiply";
                        break;
                    case "/":
                    case "divide":
                        return "divide";
                        break;
                    case "^":
                   
                    default:
                        Console.WriteLine("enter a valid operation");
                        break;
                }
            }
        }
    }
}


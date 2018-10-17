using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter(); // convert string to number
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Please enter the first number of your calculation.");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Please enter the second number of your calculation.");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Please enter: Add(+), Subtract(-), Multiply(*), or Divide(/)");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.Write("The result is: ");
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                // we would normally log this message
                Console.WriteLine(e.Message);
                
            }
          

        }
    }
}

/*
 The above calculator works in the following way:

    Please enter the first number of your calculation.
10
Please enter the second number of your calculation.
20
Please enter: Add(+), Subtract(-), Multiply(*), or Divide(/)
*
The result is: 200
Press any key to continue . . .

It is also built to handle exceptions, examples:
Please enter the first number of your calculation.
10
Please enter the second number of your calculation.
Shane
Please enter a numeric value.
Press any key to continue . . .

--AND--

Please enter the first number of your calculation.
10
Please enter the second number of your calculation.
20
Please enter: Add(+), Subtract(-), Multiply(*), or Divide(/)
Shane
Specified operation is not recognized.
Press any key to continue . . .


 */

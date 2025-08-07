using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaadiyasCSApp
{
    internal class Calculator
    {
        static void Main()
        {
            bool keepRunning = true;

            List<string> operators = new List<string> { "+", "-", "*", "/" };

            while (keepRunning)
            {
                Console.Clear();

                Console.WriteLine("=== Simple Calculator ===");

                Console.Write("Available operators: ");
                foreach (var op in operators)
                {
                    Console.Write(op + " ");
                }
                Console.WriteLine("\n");

                double num1;
                while (true)
                {
                    Console.Write("Enter the first number: ");
                    string? input1 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input1))
                    {
                        Console.WriteLine("Input cannot be empty. Try again.");
                        continue;
                    }

                    if (double.TryParse(input1, out num1))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Try again.");
                    }
                }

                // Getting the operator
                string? inputOp;
                while (true)
                {
                    Console.Write("Enter operator (+, -, *, /): ");
                    inputOp = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(inputOp))
                    {
                        Console.WriteLine("Operator cannot be empty. Try again.");
                        continue;
                    }

                    // have sued swtch to validate the operator
                    switch (inputOp)
                    {
                        case "+":
                        case "-":
                        case "*":
                        case "/":
                            goto OperatorValid;
                        default:
                            Console.WriteLine("Invalid operator. Try again.");
                            break;
                    }
                }

            OperatorValid:

                double num2;
                while (true)
                {
                    Console.Write("Enter the second number: ");
                    string? input2 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input2))
                    {
                        Console.WriteLine("Input cannot be empty. Try again.");
                        continue;
                    }

                    if (double.TryParse(input2, out num2))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Try again.");
                    }
                }

                double result = 0;
                bool valid = true;

                switch (inputOp)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                            valid = false;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                }

                if (valid)
                {
                    Console.WriteLine($"Result: {result}");
                }

                Console.Write("\nDo you want to perform another calculation? (y/n): ");
                string? choice = Console.ReadLine();

                if (choice == null || choice.Trim().ToLower() != "y")
                {
                    keepRunning = false;
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}
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

            // Available operators list for foreach demo
            List<string> operators = new List<string> { "+", "-", "*", "/" };

            while (keepRunning)
            {
                Console.Clear();

                Console.WriteLine("=== Simple Calculator ===");

                // Display available operators using foreach
                Console.Write("Available operators: ");
                foreach (var op in operators)
                {
                    Console.Write(op + " ");
                }
                Console.WriteLine("\n");

                // 1. Get the first number
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

                // 2. Get the operator
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

                    // Use switch to validate operator
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

                // 3. Get the second number
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

                // 4. Perform calculation
                double result = 0;
                bool valid = true;

                // Use switch for calculation instead of if/else
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

                // 5. Ask if user wants to continue
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
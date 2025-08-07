using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaadiyasCSApp
{
    internal class EvenOrOdd
    {
        
            static void Main()
        {
            while (true)
            {
                int number;
                string? input;

                
                while (true)
                {
                    Console.Write("Enter a number: ");
                    input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Input cannot be empty. Please try again.");
                        continue;
                    }

                    if (int.TryParse(input, out number))
                    {
                        break; // to valid number entered
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }

                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is even.");
                }
                else
                {
                    Console.WriteLine($"{number} is odd.");
                }

                Console.Write("\nDo you want to check another number? (y/n): ");
                string? choice = Console.ReadLine();

                if (choice == null || choice.Trim().ToLower() != "y")
                {
                    Console.WriteLine("Goodbye!");
                    break; // exit the main loop
                }

                Console.WriteLine(); // blank line for spacing
            }
        }
    }
}

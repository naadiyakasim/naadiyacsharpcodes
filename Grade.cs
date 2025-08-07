using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaadiyasCSApp
{
    internal class Grade
    {
        static void Main()
        {
            while (true)
            {
                int marks;
                string? input;

                while (true)
                {
                    Console.Write("Enter your marks (0 to 100): ");
                    input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Input cannot be empty. Try again.");
                        continue;
                    }

                    if (int.TryParse(input, out marks))
                    {
                        if (marks >= 0 && marks <= 100)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Marks must be between 0 and 100.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }

                string grade;

                if (marks >= 90)
                    grade = "A+";
                else if (marks >= 80)
                    grade = "A";
                else if (marks >= 70)
                    grade = "B";
                else if (marks >= 60)
                    grade = "C";
                else if (marks >= 50)
                    grade = "D";
                else
                    grade = "F";

                Console.WriteLine($"Your grade is: {grade}");

                Console.Write("\nDo you want to check another grade? (y/n): ");
                string? choice = Console.ReadLine();

                if (choice == null || choice.Trim().ToLower() != "y")
                {
                    Console.WriteLine("Thank you!!");
                    break;
                }

                Console.WriteLine(); 
            }
        }
    }
}

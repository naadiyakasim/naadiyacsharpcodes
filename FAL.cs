using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaadiyasCSApp
{
    internal class FAL
    {
        static void Main(string[] args)
        {
            string[] subjects = { "English", "Maths", "Science", "Arabic" };
            List<int> scores = new List<int>();

            foreach (string subject in subjects)
            {
                int score = GetScore(subject);
                scores.Add(score);
            }

            Console.WriteLine("\n Score :");
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"{subjects[i]}: {scores[i]}");
            }

            double average = CalculateAverage(scores);
            Console.WriteLine($"\nAverage Score: {average:F2}");
        }

        static int GetScore(string subject)
        {
            int score;
            bool isValid = false;

            do
            {
                Console.Write($"Enter score in {subject} (0 - 100): ");
                string input = Console.ReadLine();

                
                if (int.TryParse(input, out score)) // Try to parse input as integer
                {
                    if (score >= 0 && score <= 100)
                    {
                        isValid = true; // valid input
                    }
                    else
                    {
                        Console.WriteLine(" Score must be between 0 and 100.");
                    }
                }
                else
                {
                    Console.WriteLine(" Invalid input. Please enter a number.");
                }

            } while (!isValid);

            return score;
        }

        static double CalculateAverage(List<int> scoreList)
        {
            int total = 0;
            foreach (int score in scoreList)
            {
                total += score;
            }

            return (double)total / scoreList.Count;
        }
    }
}

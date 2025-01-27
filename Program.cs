using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");

            // Generate a random number
            Random random = new Random();
            int secretNumber = random.Next(1, 101); // Random number between 1 and 100
            int attempts = 0;
            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine() ?? string.Empty; // Default to an empty string if null

                int guess;
                if (int.TryParse(input, out guess))
                {
                    attempts++;
                    if (guess == secretNumber)
                    {
                        Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                        guessedCorrectly = true;
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}


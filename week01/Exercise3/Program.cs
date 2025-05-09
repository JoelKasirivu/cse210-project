using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true; // Variable to control the loop

        while (playAgain)
        {
            // Generate a random magic number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guessCount = 0;
            int useGuess = -1;

            Console.WriteLine("Welcome to the Magic Number Game!");
            // Game loop
            while (useGuess != magicNumber)
            {
                Console.Write("Guess the magic number (between 1 and 100): ");
                string input = Console.ReadLine();

                // Validate input
                if (!int.TryParse(input, out useGuess) || useGuess < 1 || useGuess > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                    continue; // Skip to the next iteration of the loop
                }

                guessCount++;

                // Check if the guess is correct

                if (useGuess < magicNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (useGuess > magicNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }

                // Ask if the user wants to play again
                Console.Write("Do you want to play again? (yes/no): ");
                string response = Console.ReadLine().ToLower();
                playAgain = response == "yes" || response == "y";


            
            }
                
        }

    }
}
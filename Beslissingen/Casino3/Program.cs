using System;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4.8 Casino");

            Random randomGenerator = new Random();
            int luckyNumber = randomGenerator.Next(1, 6); //(1-2-3-4-5)

            Console.WriteLine("\nDear, this casino machine has generated a random number between 0 and 7" +
                ", please try to guess which number (1-2-3-4-5) ;");
            int guess = Convert.ToInt32(Console.ReadLine());
            bool guessedCorrect = false;
            int attempts = 1;
            int allowedTries = 3;

            while (guessedCorrect != true)
            {
                if (attempts >= allowedTries)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ooooh, you failed to guess the correct number after {attempts} times.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
                if (guess == luckyNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congrats, you guessed the correct number, Proficiat!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    guessedCorrect = true;
                }
                else
                {
                    attempts++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ooooh, wrong guess, please try again.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}

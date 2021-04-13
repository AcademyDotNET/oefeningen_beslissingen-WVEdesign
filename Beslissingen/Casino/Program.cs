using System;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4.7 Casino");

            Random randomGenerator = new Random();
            int luckyNumber = randomGenerator.Next(1, 6); //(1-2-3-4-5)

            Console.WriteLine("\nDear, this casino machine has generated a random number between 0 and 7" +
                ", please try to guess which number (1-2-3-4-5) ;");
            int guess = Convert.ToInt32(Console.ReadLine());
                      
            if(guess == luckyNumber)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Proficiat");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("you lose");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}

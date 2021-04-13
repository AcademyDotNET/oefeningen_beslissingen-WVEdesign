using System;

namespace GuntherD_Stemwijzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("4.11 GuntherD Stemwijzer");
            Console.ForegroundColor = ConsoleColor.Gray;

            int vraag = 1;
            bool answerFound = false;

            while (answerFound != true)
            {
                switch (vraag)
                {
                    case 1: // Werk je veel?
                        if (year % 4 == 0)
                        {
                            stap = 2;
                        }
                        else
                        {
                            stap = 5;
                        }
                        break;
                    case 2: // eet je vaak Quinoa?
                        if (year % 100 == 0)
                        {
                            stap = 3;
                        }
                        else
                        {
                            stap = 4;
                        }
                        break;
                    case 3: 
                        if (year % 400 == 0)
                        {
                            stap = 4;
                        }
                        else
                        {
                            stap = 5;
                        }
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nJa, {year} is een schrikkeljaar");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        answerFound = true;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nNee, {year} is geen schrikkeljaar");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        answerFound = true;
                        break;
                    default:
                        stap = 1;
                        break;
                }
            }
        }
    }
}
